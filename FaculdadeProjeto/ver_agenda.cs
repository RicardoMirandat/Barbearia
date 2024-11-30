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
using ClosedXML.Excel;
namespace FaculdadeProjeto
{
    public partial class ver_agenda : Form
    {
        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;

        string id;


        public ver_agenda()
        {
            InitializeComponent();
        }


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

        private void ver_agenda_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void txt_Buscar_nome_TextChanged(object sender, EventArgs e)
        {
            con.Abrir_Conexao();
            sql = "SELECT * FROM servicos WHERE nome LIKE @nome ORDER BY nome ASC"; // Busca por aproximação no nome
            cmd = new MySqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@nome", txt_Buscar_nome.Text + "%"); // Busca com operador LIKE
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabela_dados.DataSource = dt;
            con.Fechar_Conexao();

            FormatarGD();
        }

        private void txt_Buscar_corte_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Baixar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Servicos");

                    for (int col = 0; col < tabela_dados.Columns.Count; col++)
                    {
                        worksheet.Cell(1, col + 1).Value = tabela_dados.Columns[col].HeaderText;
                    }

                    for (int row = 0; row < tabela_dados.Rows.Count; row++)
                    {
                        for (int col = 0; col < tabela_dados.Columns.Count; col++)
                        {
                            if (tabela_dados.Rows[row].Cells[col].Value != null)
                            {
                                worksheet.Cell(row + 2, col + 1).Value = tabela_dados.Rows[row].Cells[col].Value.ToString();
                            }
                        }
                    }

                   
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "Excel Files (*.xlsx)|*.xlsx",
                        FileName = "AgendaServicos.xlsx"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar para Excel: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
}
