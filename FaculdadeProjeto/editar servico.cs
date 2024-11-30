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
    public partial class menu : Form
    {
        //instanciando com a classe conexao
        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;

        string id;

        public menu()
        {
            InitializeComponent();
        }


        //adicionando os cabeçalhos na tabela
        private void FormatarGD()
        {
            tabela_dados.Columns[5].HeaderText = "nome";
            tabela_dados.Columns[0].HeaderText = "corte";
            tabela_dados.Columns[1].HeaderText = "descricao";
            tabela_dados.Columns[2].HeaderText = "preco";
            tabela_dados.Columns[3].HeaderText = "horario";
            tabela_dados.Columns[4].HeaderText = "data";
            tabela_dados.Columns[6].HeaderText = "id";


            tabela_dados.Columns[6].Visible = false;
        }



        //pegando os dados o banco e colocando na tabela
        private void ListarGrid()
        {
            con.Abrir_Conexao();
            sql = "SELECT * FROM `servicos` ORDER BY NOME ASC";
            cmd = new MySqlCommand(sql, con.con);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela_dados.DataSource = dt;
            con.Fechar_Conexao();

            FormatarGD();



        }

        private void btn_salvar_alteracao_Click(object sender, EventArgs e)
        {

           

            DateTime data = txt_data.Value;
            DateTime hora = txt_Hora.Value;


            con.Abrir_Conexao();
            sql = "UPDATE servicos SET servico=@servico, descricao=@descricao, preco=@preco, nome=@nome, data=@data, hora=@hora  WHERE id=@id";
            cmd = new MySqlCommand(sql, con.con);

            // Adicionando os parâmetros necessários
            cmd.Parameters.AddWithValue("@servico", txt_servico_Edit.Text);
            cmd.Parameters.AddWithValue("@descricao", txt_Descricao_Edit.Text);
            cmd.Parameters.AddWithValue("@preco", txt_Preco_Edit.Text);
            cmd.Parameters.AddWithValue("@nome", txt_Nome_Edit.Text);
            cmd.Parameters.AddWithValue("@id", id );
            cmd.Parameters.AddWithValue("@data", data.Date);
            cmd.Parameters.AddWithValue("@hora", hora.TimeOfDay);

            // Executando o comando e fechando a conexão
            cmd.ExecuteNonQuery();
            con.Fechar_Conexao();


            txt_servico_Edit.Text = "";
            txt_Descricao_Edit.Text = "";
            txt_Preco_Edit.Text = "";
            txt_Nome_Edit.Text = "";


            ListarGrid();
        }
        private void menu_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void tabela_dados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_servico_Edit.Text = tabela_dados.CurrentRow.Cells[0].Value.ToString();
            txt_Descricao_Edit.Text = tabela_dados.CurrentRow.Cells[1].Value.ToString();
            txt_Preco_Edit.Text = tabela_dados.CurrentRow.Cells[2].Value.ToString();
            txt_Hora.Text = tabela_dados.CurrentRow.Cells[3].Value.ToString();
            txt_data.Text = tabela_dados.CurrentRow.Cells[4].Value.ToString();
            id = tabela_dados.CurrentRow.Cells[6].Value.ToString();
            txt_Nome_Edit.Text = tabela_dados.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            // Confirmação antes de excluir
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    con.Abrir_Conexao();
                    sql = "DELETE FROM servicos WHERE id=@id";
                    cmd = new MySqlCommand(sql, con.con);

                    // Adicionando o parâmetro do ID
                    cmd.Parameters.AddWithValue("@id", id);

                    // Executando o comando e fechando a conexão
                    cmd.ExecuteNonQuery();
                    con.Fechar_Conexao();

                    MessageBox.Show("Registro excluído com sucesso!");

                    // Limpa os campos após exclusão
                    txt_servico_Edit.Text = "";
                    txt_Descricao_Edit.Text = "";
                    txt_Preco_Edit.Text = "";
                    txt_Nome_Edit.Text = "";
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o registro: " + ex.Message);
                }
                finally
                {
                    con.Fechar_Conexao();
                }
            }

            ListarGrid();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_bucar_item_TextChanged(object sender, EventArgs e)
        {

            con.Abrir_Conexao();
            sql = "SELECT * FROM servicos WHERE nome LIKE @nome ORDER BY nome ASC"; // Busca por aproximação no nome
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txt_bucar_item.Text + "%"); // Busca com operador LIKE
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela_dados.DataSource = dt;
            con.Fechar_Conexao();

            FormatarGD();

        }

        private void tabela_dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
