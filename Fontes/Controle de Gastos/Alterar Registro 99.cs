using Bll;
using Dal;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Alterar_Registro_99 : Form
    {
        private cls99Bll cls99Bll = new cls99Bll();
        private cls99Dto Pop99 = new cls99Dto();

        public Alterar_Registro_99()
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

            // clsEstadosBll estbll = new clsEstadosBll(); -- linha comentada apos declaracao global
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

            txt_ID99.Text = Grid99[0, linhaSelecionada].Value.ToString();
            txt_DATA99.Text = Grid99[1, linhaSelecionada].Value.ToString();
            txt_COMBUSTIVEL99.Text = Grid99[2, linhaSelecionada].Value.ToString();
            txt_Horas99.Text = Grid99[3, linhaSelecionada].Value.ToString();
            txt_KM99.Text = Grid99[4, linhaSelecionada].Value.ToString();
            txt_CORRIDAS99.Text = Grid99[5, linhaSelecionada].Value.ToString();
            txt_GANHOS99.Text = Grid99[6, linhaSelecionada].Value.ToString();
            txt_GASTOS99.Text = Grid99[7, linhaSelecionada].Value.ToString();
            txt_OBS99.Text = Grid99[8, linhaSelecionada].Value.ToString();
        }
        private void btn_AlterarRegistro_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO DATA
            if (txt_DATA99.Text == "")
            {
                MessageBox.Show("A DATA é obrigatório");
                txt_DATA99.Focus();
            }
            // VALIDAÇÃO DO CAMPO KM
            if (txt_KM99.Text == "")
            {
                MessageBox.Show("O campo KM é obrigatório");
                txt_KM99.Focus();
            }
            // VALIDAÇÃO DO CAMPO CORRIDAS
            else if (txt_CORRIDAS99.Text == "")
            {
                MessageBox.Show("O CORRIDAS é obrigatório");
                txt_CORRIDAS99.Focus();
            }
            // VALIDAÇÃO DO CAMPO COMBUSTIVEL
            if (txt_COMBUSTIVEL99.Text == "")
            {
                MessageBox.Show("O campo COMBUSTIVEL é obrigatório");
                txt_COMBUSTIVEL99.Focus();
            }
            // VALIDAÇÃO DO CAMPO TIPO DE GANHOS
            else if (txt_GANHOS99.Text == "")
            {
                MessageBox.Show("OS GANHOS são obrigatórios");
                txt_GANHOS99.Focus();
            }

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Pop99.IdCarro = Convert.ToInt32(txt_ID99.Text.ToString());
                Pop99.DatadaCorridas = Convert.ToDateTime(txt_DATA99.Text);
                Pop99.Corridas = Convert.ToInt32(txt_CORRIDAS99.Text);
                Pop99.Horas = (txt_Horas99.Text);
                Pop99.KM = (txt_KM99.Text);
                Pop99.Combustivel = txt_COMBUSTIVEL99.Text;
                Pop99.Ganhos = txt_GANHOS99.Text;
                Pop99.Gastos = txt_GASTOS99.Text;
                Pop99.OBS99 = txt_OBS99.Text;

                cls99Bll.Alterar(Pop99);

                MessageBox.Show("Registro Alterado com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();

            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
        }

        private void Grid99_SelectionChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
            FormatarGrid();
        }

        private void btn_VOLTAR_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
