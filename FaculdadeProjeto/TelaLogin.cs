using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace FaculdadeProjeto
{
    public partial class TelaLogin : Form
    {
        conexao con = new conexao();

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Usuario_Login.Text) || string.IsNullOrWhiteSpace(txt_Senha_Login.Text))
            {
                MessageBox.Show("Digite os dados corretamente.");
                txt_Usuario_Login.Text = "";
                txt_Usuario_Login.Focus();
                return;
            }

            try
            {
                con.Abrir_Conexao();
                MySqlCommand cmdverificar = new MySqlCommand("SELECT * FROM adm WHERE nome=@nome AND senha=@senha", con.con);
                cmdverificar.Parameters.AddWithValue("@nome", txt_Usuario_Login.Text);
                cmdverificar.Parameters.AddWithValue("@senha", txt_Senha_Login.Text);

                MySqlDataReader reader = cmdverificar.ExecuteReader();

                if (reader.HasRows)
                {
                    menuPrincipal frm = new menuPrincipal();
                    frm.Show(); // ou frm.ShowDialog() se preferir uma janela modal
                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
            finally
            {
                con.Fechar_Conexao(); // Assegura que a conexão será fechada
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
          
        }
    }
}
