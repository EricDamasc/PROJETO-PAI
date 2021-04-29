using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class Tela_de_Login : Form
    {
        private static String _stringConexao = "Data Source=ERIC; " +
                                               "Database=ControleDeGastos;" +
                                               "Trusted_Connection=true; ";
        private static SqlConnection _conexao;

        public Tela_de_Login()
        {
            InitializeComponent();

        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            Adicionar_Motorista adicionar = new Adicionar_Motorista();
            adicionar.Show();
        }

        private void btnLOGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPLACALOGIN.Text == "" || txtSENHALOGIN.Text == "") //Campos vazios
                {
                    if (txtPLACALOGIN.Text == "") //txtuser vazia
                    {
                        MessageBox.Show("Campo PLACA está vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSENHALOGIN.Text = "";
                        txtSENHALOGIN.Focus();
                    }
                    else if (txtSENHALOGIN.Text == "") //txtPass vazia
                    {
                        MessageBox.Show("Campo SENHA vazio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSENHALOGIN.Text = "";
                        txtSENHALOGIN.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Por favor verifique os dados de login!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPLACALOGIN.Text = "";
                        txtSENHALOGIN.Text = "";
                    }
                }
                else
                {
                    _conexao = new SqlConnection(_stringConexao);
                    _conexao.Open();
                    String placa = txtPLACALOGIN.Text;
                    string senha = txtSENHALOGIN.Text;
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Motoristas WHERE placa='" + txtPLACALOGIN.Text + "' AND senha ='" + txtSENHALOGIN.Text + "'", _conexao);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        //Abre Form Geral caso os dados do Login estejam certos
                        Controle_de_Gastos Controle = new Controle_de_Gastos();
                        Controle.Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifique os dados inseridos!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (_stringConexao != null)
                {
                    _stringConexao.Clone();
                }
            }
        }

        private void btnLOGOUT_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
