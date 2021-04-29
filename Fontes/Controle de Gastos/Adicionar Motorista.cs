using Bll;
using Dto;
using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Adicionar_Motorista : Form
    {
        private MotoristaBll MotoristaBll = new MotoristaBll();
        private MotoristaDto Motorista = new MotoristaDto();

        public Adicionar_Motorista()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            // VALIDAÇÃO DO CAMPO PLACA
            if (txt_PLACA.Text == "")
            {
                MessageBox.Show("A PLACA é obrigatório");
                txt_PLACA.Focus();
            }
            // VALIDAÇÃO DO CAMPO MOTORISTA
            if (txt_MOTORISTAS.Text == "")
            {
                MessageBox.Show("O campo MOTORISTA é obrigatório");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO SENHA
            if (txt_Senha.Text == "")
            {
                MessageBox.Show("O campo SENHA é obrigatório");
                Focus();
            }
            // COINFIRMAÇÃO DE SENHA
            if (txt_Senha.Text != txt_SenhaConfirmar.Text)
            {
                MessageBox.Show("A senha não Coincidem");
                Focus();
            }
            // VALIDAÇÃO DO CAMPO DATA
            if (txt_DATADEINICIO.Text == "")
            {
                MessageBox.Show("O campo DATA DE INICIO é obrigatório");
                txt_DATADEINICIO.Focus();
            }

            else if (MessageBox.Show("Confirma a inserção?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Motorista.Placa = txt_PLACA.Text;
                Motorista.Senha = txt_Senha.Text;
                Motorista.motorista = (txt_MOTORISTAS.Text);
                Motorista.Carro = (txt_CARRO.Text);
                Motorista.Data = Convert.ToDateTime(txt_DATADEINICIO.Text);

                MotoristaBll.Inserir(Motorista);

                MessageBox.Show("Motorista inserido com sucesso!", "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("PREENCHA OS CAMPOS CORRETAMENTE!");
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
