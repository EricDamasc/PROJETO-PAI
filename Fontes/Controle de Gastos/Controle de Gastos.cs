using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Controle_de_Gastos : Form
    {
        public Controle_de_Gastos()
        {
            InitializeComponent();
        }

        private void btn_SAIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            Barra_Progresso.Start();
        }

        private void Barra_Progresso_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
        }

        private void CAT_ResultadosUBER_Click(object sender, EventArgs e)
        {
            Tela_da_Uber tela_Da_Uber = new Tela_da_Uber();
            tela_Da_Uber.ShowDialog();
        }

        private void CAT_ADDRegistroUBER_Click(object sender, EventArgs e)
        {
            Controle_da_Uber uber = new Controle_da_Uber();
            uber.ShowDialog();
        }

        private void CAT_ADD_Motoristas_Click(object sender, EventArgs e)
        {
            Adicionar_Motorista motorista = new Adicionar_Motorista();
            motorista.ShowDialog();
        }

        private void CAT_AlterarUBER_Click(object sender, EventArgs e)
        {
            Alterar_Registro alterar = new Alterar_Registro();
            alterar.ShowDialog();
        }

        private void CAT_ExcluirUBER_Click(object sender, EventArgs e)
        {
            Excluir_Registro excluir = new Excluir_Registro();
            excluir.ShowDialog();
        }

        private void CAT_ADDRegistro99_Click(object sender, EventArgs e)
        {
            Controle_99 _99 = new Controle_99();
            _99.ShowDialog();
        }

        private void CAT_Informações_Click(object sender, EventArgs e)
        {
            Informações informações = new Informações();
            informações.ShowDialog();
        }

        private void CAT_EXIBIRRegistro99_Click(object sender, EventArgs e)
        {
            Tela_da_99 tela_Da_99 = new Tela_da_99();
            tela_Da_99.ShowDialog();
        }

        private void CAT_AlterarRegistro99_Click(object sender, EventArgs e)
        {
            Alterar_Registro_99 registro_99 = new Alterar_Registro_99();
            registro_99.ShowDialog();
        }

        private void CAT_ExcluirRegistro99_Click(object sender, EventArgs e)
        {
            Excluir_Registro_99 excluir = new Excluir_Registro_99();
            excluir.ShowDialog();
        }

        private void CAT_AlcoolGasolina_Click(object sender, EventArgs e)
        {
            Calculadora_de_Combustivel calculadora = new Calculadora_de_Combustivel();
            calculadora.ShowDialog();
        }

        private void CAT_MetaDiaria_Click(object sender, EventArgs e)
        {
            Metas metas = new Metas();
            metas.ShowDialog();
        }
    }
}
