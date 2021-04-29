using Bll;
using Dal;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Tela_da_99 : Form
    {
        private cls99Bll cls99Bll = new cls99Bll();
        private cls99Dto Pop99 = new cls99Dto();

        public Tela_da_99()
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
            Grid99.AutoGenerateColumns = true;

            try
            {
                if (tipo == 0)
                {
                    Grid99.DataSource = cls99Bll.ObterDados(0, String.Empty);
                }
                else
                {
                    if (tipo == 1)
                    {
                        Grid99.DataSource = cls99Bll.ObterDados(1, filtro);
                    }
                    else
                    {
                        if (tipo == 2)
                        {
                            Grid99.DataSource = cls99Bll.ObterDados(2, filtro);
                        }
                    }
                }
                FormatarGrid();
            }

            catch
            {
                throw;
            }
        }

        private void FormatarGrid()
        {
            Grid99.ReadOnly = true;
            Grid99.ScrollBars = ScrollBars.Vertical;


            Grid99.Columns[0].HeaderText = "CORRIDA";
            Grid99.Columns[1].HeaderText = "DATA";
            Grid99.Columns[2].HeaderText = "COMBUSTÍVEL";
            Grid99.Columns[3].HeaderText = "HORAS";
            Grid99.Columns[4].HeaderText = "KM";
            Grid99.Columns[5].HeaderText = "CORRIDAS";
            Grid99.Columns[6].HeaderText = "GANHOS";
            Grid99.Columns[7].HeaderText = "GASTOS";
            Grid99.Columns[8].HeaderText = "OBS";

            Grid99.Columns[0].Width = 90;
            Grid99.Columns[1].Width = 90;
            Grid99.Columns[2].Width = 90;
            Grid99.Columns[3].Width = 90;
            Grid99.Columns[4].Width = 90;
            Grid99.Columns[5].Width = 100;
            Grid99.Columns[6].Width = 100;
            Grid99.Columns[7].Width = 100;
            Grid99.Columns[8].Width = 180;
        }

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = Grid99.CurrentRow.Index;

            txt_DATA99.Text = Grid99[1, linhaSelecionada].Value.ToString();
            txt_COMBUSTIVEL99.Text = Grid99[2, linhaSelecionada].Value.ToString().Replace("_", "").Trim();
            txt_Horas99.Text = Grid99[3, linhaSelecionada].Value.ToString();
            txt_KM99.Text = Grid99[4, linhaSelecionada].Value.ToString();
            txt_CORRIDAS99.Text = Grid99[5, linhaSelecionada].Value.ToString();
            txt_GANHOS99.Text = Grid99[6, linhaSelecionada].Value.ToString();
            txt_GASTOS99.Text = Grid99[7, linhaSelecionada].Value.ToString();
        }

        private string CalcularTotal()
        {
            double combustivel, gastos, ganhos, total = 0;
            string resultadoLucros = "";

            try
            {
                combustivel = Convert.ToDouble(txt_COMBUSTIVEL99.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "0").Trim());
                gastos = Convert.ToDouble(txt_GASTOS99.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
                ganhos = Convert.ToDouble(txt_GANHOS99.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
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

        private void Grid99_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();

            txt_Total99.Text = CalcularTotal();
        }

        private void Tela_da_99_Load1(object sender, EventArgs e)
        {
            FormatarGrid();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                cls99Dal cls99Dal = new cls99Dal();

                if (cmb_Periodo.Text == "DATA")
                {
                    Grid99.DataSource = cls99Dal.obterData("");
                }
                else if (cmb_Periodo.Text == "CORRIDAS")
                {
                    Grid99.DataSource = cls99Dal.obterCorridas("CORRIDAS");
                }
                else if (cmb_Periodo.Text == "COMBUSTIVEL")
                {
                    Grid99.DataSource = cls99Dal.obterCombustivel("COMBUSTIVEL");
                }
            }
            catch
            {
                MessageBox.Show("INFORME OS DADOS QUE DESEJA REALIZAR A BUSCA.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_VOLTAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (Grid99.Rows.Count > 0)
            {
                try
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < Grid99.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = Grid99.Columns[i - 1].HeaderText.Trim();
                    }
                    for (int i = 10; i < Grid99.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[10, i] = Grid99.Columns[i - 1].ToString().Trim();
                    }
                    //
                    for (int i = 0; i < Grid99.Rows.Count; i++)
                    {
                        for (int j = 0; j < Grid99.Columns.Count; j++)
                        {
                            if (j == 10)
                            {
                                string combustivel = txt_COMBUSTIVEL99.Text;
                                string ganhos = txt_GANHOS99.Text;
                                string gastos = txt_GASTOS99.Text;

                                txt_COMBUSTIVEL99.Text = Grid99.Rows[i].Cells[2].Value.ToString();
                                txt_GANHOS99.Text = Grid99.Rows[i].Cells[6].Value.ToString();
                                txt_GASTOS99.Text = Grid99.Rows[i].Cells[7].Value.ToString();

                                XcelApp.Cells[i + 2, j + 1] = CalcularTotal().Trim();

                                txt_COMBUSTIVEL99.Text = combustivel;
                                txt_GANHOS99.Text = ganhos;
                                txt_GASTOS99.Text = gastos;

                            }
                            else
                            {
                                XcelApp.Cells[i + 2, j + 1] = Grid99.Rows[i].Cells[j].Value.ToString().Replace("00:00:00", "").Trim();
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
    }
}
