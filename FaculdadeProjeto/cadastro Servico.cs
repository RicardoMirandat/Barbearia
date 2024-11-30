using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FaculdadeProjeto
{
    public partial class cadastro_Servico : Form
    {
        //instanciando com a classe conexao
        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;
        
        public cadastro_Servico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //caixa de opcoes de corte
            string servicoSelecionado = string.Join(", ", checkedListBox1.CheckedItems.OfType<string>());

            //data e hora
            DateTime data = txt_data.Value; 
            DateTime hora = txt_Hora.Value; 





            //salvando no banco de dados
            con.Abrir_Conexao();
           sql = "INSERT INTO servicos(servico, descricao, preco, hora, data, nome) VALUES (@servico,@descricao,@preco,@hora,@data,@nome)";
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@servico", servicoSelecionado);
            cmd.Parameters.AddWithValue("@descricao", txt_descricao.Text);
            cmd.Parameters.AddWithValue(@"preco", txt_preco.Text);
            cmd.Parameters.AddWithValue("@data", data.Date); 
            cmd.Parameters.AddWithValue("@hora", hora.TimeOfDay);
            cmd.Parameters.AddWithValue("@nome", txt_nome.Text);

            cmd.ExecuteNonQuery();
            con.Fechar_Conexao();



            //limpando os campos apos salvar
            txt_descricao.Text = "";
            txt_preco.Text = "";
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);  
            }
            MessageBox.Show("Serviço salvo com sucesso!");

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastro_Servico_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
