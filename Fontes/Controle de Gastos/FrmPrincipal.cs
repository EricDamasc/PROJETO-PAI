using System;
using System.Windows.Forms;

namespace Controle_de_Gastos
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_Comecar_Click(object sender, EventArgs e)
        {
            // Alerta para prazo de validade 
            DateTime hoje = DateTime.Now;
            DateTime obtida = DateTime.Parse("01/07/2022");
            if (hoje >= obtida)
            {
                Console.Beep();
                MessageBox.Show("SUA LICENÇA TERMINOU HOJE: " + DateTime.Today.Date + " ENTRE EM CONTATO COM O DESENVOLVEDOR ", " CONTATE O SUPORTE ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                Tela_de_Login login = new Tela_de_Login();
                login.ShowDialog();
            }
        }

        private void DescobrirDiretoriosPadrao(out string diretorioDados, out string diretorioLog, out string diretorioBackup)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection("Server=(localdb)\\mssqllocaldb;Database=ControleDeGastos;Trusted_Connection=True;"))
            {
                var serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(connection);
                var server = new Microsoft.SqlServer.Management.Smo.Server(serverConnection);
                diretorioDados = !string.IsNullOrWhiteSpace(server.Settings.DefaultFile) ? server.Settings.DefaultFile : (!string.IsNullOrWhiteSpace(server.DefaultFile) ? server.DefaultFile : server.MasterDBPath);
                diretorioLog = !string.IsNullOrWhiteSpace(server.Settings.DefaultLog) ? server.Settings.DefaultLog : (!string.IsNullOrWhiteSpace(server.DefaultLog) ? server.DefaultLog : server.MasterDBLogPath);
                diretorioBackup = !string.IsNullOrWhiteSpace(server.Settings.BackupDirectory) ? server.Settings.BackupDirectory : server.BackupDirectory;
            }
        }

        private bool VerificaSeBancoJaExiste()
        {
            bool retorno = false;

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection("Server=(localdb)\\mssqllocaldb;Database=ControleDeGastos;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        comm.CommandText = "SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'ControleDeGastos'";
                        var valor = comm.ExecuteScalar();

                        if (valor != null && valor != DBNull.Value && Convert.ToInt32(valor).Equals(1))
                        {
                            retorno = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        private void RestaurarDBPadrao()

        {
            try
            {
                string diretorioDados, diretorioLog, diretorioBackup;
                DescobrirDiretoriosPadrao(out diretorioDados, out diretorioLog, out diretorioBackup);

                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        var caminhoCompletoBackup = System.IO.Path.Combine(diretorioBackup, "ControleDeGastos.bak");
                        var caminhoCompletoDados = System.IO.Path.Combine(diretorioDados, "ControleDeGastos.mdf");
                        var caminhoCompletoLog = System.IO.Path.Combine(diretorioLog, "ControleDeGastos_log.ldf");
                        System.IO.File.Copy("ControleDeGastos.bak", caminhoCompletoBackup, true);
                        comm.CommandText =
                            @"RESTORE DATABASE ControleDeGastos " +
                            @"FROM DISK = N'" + caminhoCompletoBackup + "' " +
                            @"WITH FILE = 1, " +
                            @"MOVE N'ControleDeGastos' TO N'" + caminhoCompletoDados + "', " +
                            @"MOVE N'ControleDeGastos_log' TO N'" + caminhoCompletoLog + "', " +
                            @"NOUNLOAD, REPLACE, STATS = 10";
                        comm.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}