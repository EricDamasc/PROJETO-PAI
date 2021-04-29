using Bll;
using Dal;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Tela_da_Uber : Form
    {
        private clsUberBll clsUberBll = new clsUberBll();
        private clsUberDto Uber = new clsUberDto();
        private clsUberDal ClsUber = new clsUberDal();
        private MotoristaBll motorista = new MotoristaBll();
        private MotoristaDal MotoristaDal = new MotoristaDal();

        public Tela_da_Uber()
        {
            InitializeComponent();
            CarregarGrid();
        }

        protected void CarregarGrid()
        {
            CarregarGrid(0, "");
        }

        private void CarregarGrid(int tipo, String filtro)
        {
            GridUber.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    GridUber.DataSource = clsUberBll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        GridUber.DataSource = clsUberBll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            GridUber.DataSource = clsUberBll.ObterDados(2, filtro);
                        }
                    }
                    FormatarGrid();
                }
            }

            catch
            {
                throw;
            }
        }

        private void FormatarGrid()
        {
            GridUber.ReadOnly = true;
            GridUber.ScrollBars = ScrollBars.Vertical;


            GridUber.Columns[0].HeaderText = "CORRIDA";
            GridUber.Columns[1].HeaderText = "DATA";
            GridUber.Columns[2].HeaderText = "COMBUSTÍVEL";
            GridUber.Columns[3].HeaderText = "HORAS";
            GridUber.Columns[4].HeaderText = "KM";
            GridUber.Columns[5].HeaderText = "CORRIDAS";
            GridUber.Columns[6].HeaderText = "GANHOS";
            GridUber.Columns[7].HeaderText = "GASTOS";
            GridUber.Columns[8].HeaderText = "OBS";

            GridUber.Columns[0].Width = 90;
            GridUber.Columns[1].Width = 90;
            GridUber.Columns[2].Width = 90;
            GridUber.Columns[3].Width = 90;
            GridUber.Columns[4].Width = 90;
            GridUber.Columns[5].Width = 100;
            GridUber.Columns[6].Width = 100;
            GridUber.Columns[7].Width = 100;
            GridUber.Columns[8].Width = 180;
        }

        private void Tela_da_Uber_Load_1(object sender, EventArgs e)
        {
            FormatarGrid();
        }

        private void btn_VOLTAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = GridUber.CurrentRow.Index;

            txt_DATAUBER.Text = GridUber[1, linhaSelecionada].Value.ToString();
            txt_COMBUSTIVELUBER.Text = GridUber[2, linhaSelecionada].Value.ToString().Replace("_", "").Trim();
            txt_HorasUber.Text = GridUber[3, linhaSelecionada].Value.ToString();
            txt_KMUBER.Text = GridUber[4, linhaSelecionada].Value.ToString();
            txt_CORRIDASUBER.Text = GridUber[5, linhaSelecionada].Value.ToString();
            txt_GANHOSUBER.Text = GridUber[6, linhaSelecionada].Value.ToString();
            txt_GASTOSUBER.Text = GridUber[7, linhaSelecionada].Value.ToString();
        }

        private string CalcularTotal()
        {
            double combustivel, gastos, ganhos, total = 0;
            string resultadoLucros = "";

            try
            {
                combustivel = Convert.ToDouble(txt_COMBUSTIVELUBER.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
                gastos = Convert.ToDouble(txt_GASTOSUBER.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
                ganhos = Convert.ToDouble(txt_GANHOSUBER.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
                total = ganhos - (combustivel + gastos);
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS NOS CALCULOS!", "AGUARDE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (total == 0)
            {
                return resultadoLucros = "Não foi possivel calcular";
            }
            else
            {
                return resultadoLucros = "R$ " + total.ToString();
            }
        }

        private void FormatarGridDIA()
        {
            GridUber.ReadOnly = true;
            GridUber.ScrollBars = ScrollBars.Vertical;

            GridUber.Columns[0].HeaderText = "CÓDIGO";
            GridUber.Columns[2].HeaderText = "GANHO";
        }

        private void FormatarGridSEMANA()
        {
            GridUber.ReadOnly = true;
            GridUber.ScrollBars = ScrollBars.Vertical;

            GridUber.Columns[0].HeaderText = "CÓDIGO";
            GridUber.Columns[2].HeaderText = "GANHO";
        }

        private void FormatarGridMÊS()
        {
            GridUber.ReadOnly = true;
            GridUber.ScrollBars = ScrollBars.Vertical;

            GridUber.Columns[0].HeaderText = "CÓDIGO";
            GridUber.Columns[2].HeaderText = "GANHO";
        }

        private void FormatarGridANO()
        {
            GridUber.ReadOnly = true;
            GridUber.ScrollBars = ScrollBars.Vertical;

            GridUber.Columns[0].HeaderText = "CÓDIGO";
            GridUber.Columns[2].HeaderText = "GANHO";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                clsUberDal clsUberDal = new clsUberDal();

                if (cmb_Periodo.Text == "DATA")
                {
                    GridUber.DataSource = clsUberDal.obterData("");
                }
                else if (cmb_Periodo.Text == "CORRIDAS")
                {
                    GridUber.DataSource = clsUberDal.obterCorridas("CORRIDAS");
                }
                else if (cmb_Periodo.Text == "COMBUSTIVEL")
                {
                    GridUber.DataSource = clsUberDal.obterCombustivel("COMBUSTIVEL");
                }
            }
            catch
            {
                MessageBox.Show("INFORME OS DADOS QUE DESEJA REALIZAR A BUSCA.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (GridUber.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < GridUber.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = GridUber.Columns[i - 1].HeaderText.Trim();
                    }
                    for (int i = 10; i < GridUber.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[10, i] = GridUber.Columns[i - 1].ToString().Trim();
                    }
                    //
                    for (int i = 0; i < GridUber.Rows.Count; i++)
                    {
                        for (int j = 0; j < GridUber.Columns.Count; j++)
                        {
                            if (j == 10)
                            {
                                string combustivel = txt_COMBUSTIVELUBER.Text;
                                string ganhos = txt_GANHOSUBER.Text;
                                string gastos = txt_GASTOSUBER.Text;

                                txt_COMBUSTIVELUBER.Text = GridUber.Rows[i].Cells[2].Value.ToString();
                                txt_GANHOSUBER.Text = GridUber.Rows[i].Cells[6].Value.ToString();
                                txt_GASTOSUBER.Text = GridUber.Rows[i].Cells[7].Value.ToString();

                                XcelApp.Cells[i + 2, j + 1] = CalcularTotal().Trim();

                                txt_COMBUSTIVELUBER.Text = combustivel;
                                txt_GANHOSUBER.Text = ganhos;
                                txt_GASTOSUBER.Text = gastos;

                            }
                            else
                            {
                                XcelApp.Cells[i + 2, j + 1] = GridUber.Rows[i].Cells[j].Value.ToString().Replace("00:00:00", "").Trim();
                            }
                        }
                    }
                    //
                    XcelApp.Columns.AutoFit();
                    //
                    XcelApp.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    XcelApp.Quit();
                }
            }
        }

        private void GridUber_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();

            txt_TotalUber.Text = CalcularTotal();
        }
    }
}