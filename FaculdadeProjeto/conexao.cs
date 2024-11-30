using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace FaculdadeProjeto
{
    class conexao
    {
        public string conec = "SERVER = localhost; DATABASE = bando_de_dados; UID=root; PWD=; PORT=; " ;

        public MySqlConnection con = null;


        public void Abrir_Conexao()
        {

            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor");
                
            }
        }


        public void Fechar_Conexao()
        {
            try
            {
                con = new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor");

            }

        }

    }
}
