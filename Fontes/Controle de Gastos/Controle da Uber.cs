using Bll;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Controle_da_Uber : Form
    {
        public clsUberBll clsUberBll = new clsUberBll();
        public clsUberDto Uber = new clsUberDto();

        public Controle_da_Uber()
        {
            InitializeComponent();
        }

        private void btn_ConfirmarUber_Click(object sender, EventArgs e)
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
            // VALIDAÇÃO DE HORAS
            if (txt_HorasUber.Text == "")
            {
                MessageBox.Show("O campo Horas é obrigatorio");
                txt_HorasUber.Focus();
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

            // VALIDAÇÃO DO CAMPO TIPO DE GASTOS
            else if (txt_GASTOSUBER.Text == "")
            {
                MessageBox.Show("Os GASTOS são obrigatórios");
                txt_GASTOSUBER.Focus();
            }

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Uber.DatadaCorridas = Convert.ToDateTime(txt_DATAUBER.Text);
                Uber.Corridas = Convert.ToInt32(txt_CORRIDASUBER.Text);
                Uber.Horas = (txt_HorasUber.Text);
                Uber.KM = (txt_KMUBER.Text);
                Uber.Combustivel = txt_COMBUSTIVELUBER.Text;
                Uber.Ganhos = txt_GANHOSUBER.Text;
                Uber.Gastos = txt_GASTOSUBER.Text;
                Uber.OBSUBER = txt_OBSUBER.Text;



                clsUberBll.Inserir(Uber);

                MessageBox.Show("Registro inserido com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
        }

        private void LimparCampos()
        {
            txt_COMBUSTIVELUBER.Text = "";
            txt_CORRIDASUBER.Text = "";
            txt_DATAUBER.Text = "";
            txt_GANHOSUBER.Text = "";
            txt_GASTOSUBER.Text = "";
            txt_HorasUber.Text = "";
            txt_KMUBER.Text = "";
            txt_OBSUBER.Text = "";
        }

        private void btn_VOLTAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_LimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}