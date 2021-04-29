using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Metas : Form
    {
        public Metas()
        {
            InitializeComponent();
        }

        private void btn_CalcularMeta_Click(object sender, EventArgs e)
        {
            double DiasTrabalho, Mdia = 0, Semana, Mes, Ano;
            string resultado;

            try
            {
                DiasTrabalho = Convert.ToInt32(cmb_Dias.Text);
                Mdia = Convert.ToDouble(txt_MetaDiaria.Text.Replace("R$", "").Trim().Replace(" ", "0").Trim());

                // VALIDANDO CAMPO DIAS TRABALHADOS
                if (cmb_Dias.Text == "DIAS")
                {
                    MessageBox.Show("SELECIONE QUANTOS DIAS VOCÊ TRABALHA NA SEMANA", "CAMPO INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // VALIDANDO VALOR DA META
                else if (Mdia < 100.00)
                {
                    MessageBox.Show("SUA META DEVE SER IGUAL OU MAIOR A R$ 100,00", "CAMPO INVÁLIDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // CALCULO DA META
                else
                {
                    Semana = Mdia * DiasTrabalho;
                    // CALCULAR META DA MÊS
                    Mes = Semana * 4;
                    // CALCULAR META DA ANO
                    Ano = Mes * 12;
                    // EXIBINDO VALORES DAS METAS
                    txt_Semana.Text = Semana.ToString();
                    txt_MES.Text = Mes.ToString();
                    txt_ANO.Text = Ano.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Corrijam Algum(s) campo(s) inválido", "RETORNE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
