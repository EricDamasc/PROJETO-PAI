using Bll;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Controle_99 : Form
    {
        public cls99Bll cls99Bll = new cls99Bll();
        public cls99Dto Taxi99 = new cls99Dto();

        public Controle_99()
        {
            InitializeComponent();
        }

        private void btn_Confirmar99_Click(object sender, EventArgs e)
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
            // VALIDAÇÃO DE HORAS
            if (txt_Horas99.Text == "")
            {
                MessageBox.Show("O campo Horas é obrigatorio");
                txt_Horas99.Focus();
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

            // VALIDAÇÃO DO CAMPO TIPO DE GASTOS
            else if (txt_GASTOS99.Text == "")
            {
                MessageBox.Show("Os GASTOS são obrigatórios");
                txt_GASTOS99.Focus();
            }

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Taxi99.DatadaCorridas = Convert.ToDateTime(txt_DATA99.Text);
                Taxi99.Corridas = Convert.ToInt32(txt_CORRIDAS99.Text);
                Taxi99.Horas = (txt_Horas99.Text);
                Taxi99.KM = (txt_KM99.Text);
                Taxi99.Combustivel = txt_COMBUSTIVEL99.Text;
                Taxi99.Ganhos = txt_GANHOS99.Text;
                Taxi99.Gastos = txt_GASTOS99.Text;
                Taxi99.OBS99 = txt_OBS99.Text;



                cls99Bll.Inserir(Taxi99);

                MessageBox.Show("Registro inserido com sucesso!", "Adicionado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
        }

        private void LimparCampos()
        {
            txt_COMBUSTIVEL99.Text = "";
            txt_CORRIDAS99.Text = "";
            txt_DATA99.Text = "";
            txt_GANHOS99.Text = "";
            txt_GASTOS99.Text = "";
            txt_Horas99.Text = "";
            txt_KM99.Text = "";
            txt_OBS99.Text = "";
        }

        private void btn_LimparCampos99_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_VOLTAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
