using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Calculadora_de_Combustivel : Form
    {
        public Calculadora_de_Combustivel()
        {
            InitializeComponent();
        }

        private void btn_Calculo_Explicacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na média, uma relação de 73% ou menos do preço do etanol em " +
             "relação ao preço da gasolina, favorece o uso do álcool. Se for 74% ou mais, use gasolina.", "COMO É FEITO CÁLCULO!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btn_CalcularCombustivel_Click(object sender, EventArgs e)
        {
            double alcool, gasolina, total = 0;
            string resultado;
            try
            {
                alcool = Convert.ToDouble(txt_Alcool.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
                gasolina = Convert.ToDouble(txt_Gasolina.Text.Replace("R$", "").Trim().Replace(".", ",").Replace("_", "").Trim());
                total = alcool / gasolina;
            }
            catch (Exception)
            {
                MessageBox.Show("PROBLEMAS NOS CALCULOS!", "AGUARDE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (total == 0)
            {
                resultado = "Não foi possivel calcular";
            }
            else
            {
                //txt_Porcentagem.Clear();
                txt_Porcentagem.Text = total.ToString();
            }
            if (total >= 0.74)
            {
                txt_Resultado.Text = "Utilize Gasolina";
            }
            else
            {
                txt_Resultado.Text = "Utilize Álcool";
            }
        }

        // AO PRESSIONA A TECLA ENTER ELE PULA PARA O PRÓXIMO TEXTBOX
        private void txt_Alcool_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
            }
        }
        // AO PRESSIONA A TECLA ENTER ELE PULA PARA O PRÓXIMO TEXTBOX
        private void txt_Gasolina_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
