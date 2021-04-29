using Bll;
using Dal;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Alterar_Registro : Form
    {
        private clsUberBll clsUberBll = new clsUberBll();
        private clsUberDto Uber = new clsUberDto();
        private clsUberDal ClsUber = new clsUberDal();
        private MotoristaBll motorista = new MotoristaBll();
        private MotoristaDal MotoristaDal = new MotoristaDal();

        public Alterar_Registro()
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

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
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

        private void AtualizarGrid()
        {
            int linhaSelecionada;

            linhaSelecionada = GridUber.CurrentRow.Index;

            txt_ID.Text = GridUber[0, linhaSelecionada].Value.ToString();
            txt_DATAUBER.Text = GridUber[1, linhaSelecionada].Value.ToString();
            txt_COMBUSTIVELUBER.Text = GridUber[2, linhaSelecionada].Value.ToString();
            txt_HorasUber.Text = GridUber[3, linhaSelecionada].Value.ToString();
            txt_KMUBER.Text = GridUber[4, linhaSelecionada].Value.ToString();
            txt_CORRIDASUBER.Text = GridUber[5, linhaSelecionada].Value.ToString();
            txt_GANHOSUBER.Text = GridUber[6, linhaSelecionada].Value.ToString();
            txt_GASTOSUBER.Text = GridUber[7, linhaSelecionada].Value.ToString();
            txt_OBSUBER.Text = GridUber[8, linhaSelecionada].Value.ToString();
        }


        private void GridUber_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
            FormatarGrid();
        }

        private void btn_VOLTAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AlterarRegistro_Click_1(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO DATA
            if (txt_DATAUBER.Text == "")
            {
                MessageBox.Show("A DATA é obrigatório");
                txt_DATAUBER.Focus();
            }
            // VALIDAÇÃO DO CAMPO KM
            if (txt_KMUBER.Text == "")
            {
                MessageBox.Show("O campo KM é obrigatório");
                txt_KMUBER.Focus();
            }
            // VALIDAÇÃO DO CAMPO CORRIDAS
            else if (txt_CORRIDASUBER.Text == "")
            {
                MessageBox.Show("O CORRIDAS é obrigatório");
                txt_CORRIDASUBER.Focus();
            }
            // VALIDAÇÃO DO CAMPO COMBUSTIVEL
            if (txt_COMBUSTIVELUBER.Text == "")
            {
                MessageBox.Show("O campo COMBUSTIVEL é obrigatório");
                txt_COMBUSTIVELUBER.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE GANHOS
            else if (txt_GANHOSUBER.Text == "")
            {
                MessageBox.Show("OS GANHOS são obrigatórios");
                txt_GANHOSUBER.Focus();
            }

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Uber.IdCarro = Convert.ToInt32(txt_ID.Text.ToString());
                Uber.DatadaCorridas = Convert.ToDateTime(txt_DATAUBER.Text);
                Uber.Corridas = Convert.ToInt32(txt_CORRIDASUBER.Text);
                Uber.Horas = (txt_HorasUber.Text);
                Uber.KM = (txt_KMUBER.Text);
                Uber.Combustivel = txt_COMBUSTIVELUBER.Text;
                Uber.Ganhos = txt_GANHOSUBER.Text;
                Uber.Gastos = txt_GASTOSUBER.Text;
                Uber.OBSUBER = txt_OBSUBER.Text;

                clsUberBll.Alterar(Uber);

                MessageBox.Show("Registro Alterado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();

            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
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
    }
}