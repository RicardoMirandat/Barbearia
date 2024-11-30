
namespace FaculdadeProjeto
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.tabela_dados = new System.Windows.Forms.DataGridView();
            this.btn_salvar_alteracao = new System.Windows.Forms.Button();
            this.txt_Nome_Edit = new System.Windows.Forms.TextBox();
            this.txt_Preco_Edit = new System.Windows.Forms.TextBox();
            this.txt_Descricao_Edit = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.DateTimePicker();
            this.txt_Hora = new System.Windows.Forms.DateTimePicker();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.txt_servico_Edit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_bucar_item = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela_dados
            // 
            this.tabela_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dados.Location = new System.Drawing.Point(56, 202);
            this.tabela_dados.Name = "tabela_dados";
            this.tabela_dados.Size = new System.Drawing.Size(657, 291);
            this.tabela_dados.TabIndex = 0;
            this.tabela_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellClick);
            this.tabela_dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_dados_CellContentClick);
            // 
            // btn_salvar_alteracao
            // 
            this.btn_salvar_alteracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar_alteracao.BackgroundImage")));
            this.btn_salvar_alteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar_alteracao.ForeColor = System.Drawing.Color.White;
            this.btn_salvar_alteracao.Location = new System.Drawing.Point(621, 513);
            this.btn_salvar_alteracao.Name = "btn_salvar_alteracao";
            this.btn_salvar_alteracao.Size = new System.Drawing.Size(153, 37);
            this.btn_salvar_alteracao.TabIndex = 1;
            this.btn_salvar_alteracao.Text = "Salvar";
            this.btn_salvar_alteracao.UseVisualStyleBackColor = true;
            this.btn_salvar_alteracao.Click += new System.EventHandler(this.btn_salvar_alteracao_Click);
            // 
            // txt_Nome_Edit
            // 
            this.txt_Nome_Edit.Location = new System.Drawing.Point(128, 74);
            this.txt_Nome_Edit.Name = "txt_Nome_Edit";
            this.txt_Nome_Edit.Size = new System.Drawing.Size(200, 20);
            this.txt_Nome_Edit.TabIndex = 3;
            // 
            // txt_Preco_Edit
            // 
            this.txt_Preco_Edit.Location = new System.Drawing.Point(128, 157);
            this.txt_Preco_Edit.Name = "txt_Preco_Edit";
            this.txt_Preco_Edit.Size = new System.Drawing.Size(200, 20);
            this.txt_Preco_Edit.TabIndex = 9;
            // 
            // txt_Descricao_Edit
            // 
            this.txt_Descricao_Edit.Location = new System.Drawing.Point(565, 117);
            this.txt_Descricao_Edit.Name = "txt_Descricao_Edit";
            this.txt_Descricao_Edit.Size = new System.Drawing.Size(200, 20);
            this.txt_Descricao_Edit.TabIndex = 10;
            // 
            // txt_data
            // 
            this.txt_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data.Location = new System.Drawing.Point(128, 119);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(200, 20);
            this.txt_data.TabIndex = 16;
            this.txt_data.Value = new System.DateTime(2024, 10, 28, 22, 47, 0, 0);
            // 
            // txt_Hora
            // 
            this.txt_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txt_Hora.Location = new System.Drawing.Point(565, 154);
            this.txt_Hora.Name = "txt_Hora";
            this.txt_Hora.Size = new System.Drawing.Size(200, 20);
            this.txt_Hora.TabIndex = 17;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir.BackgroundImage")));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(319, 513);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(135, 37);
            this.btn_excluir.TabIndex = 18;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // txt_servico_Edit
            // 
            this.txt_servico_Edit.Location = new System.Drawing.Point(565, 77);
            this.txt_servico_Edit.Name = "txt_servico_Edit";
            this.txt_servico_Edit.Size = new System.Drawing.Size(200, 20);
            this.txt_servico_Edit.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "buscar por nome:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_bucar_item
            // 
            this.txt_bucar_item.Location = new System.Drawing.Point(342, 32);
            this.txt_bucar_item.Name = "txt_bucar_item";
            this.txt_bucar_item.Size = new System.Drawing.Size(202, 20);
            this.txt_bucar_item.TabIndex = 21;
            this.txt_bucar_item.TextChanged += new System.EventHandler(this.txt_bucar_item_TextChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_voltar.BackgroundImage")));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(12, 513);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(114, 37);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(786, 562);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(184, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Buscar Por Nome:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "Data:";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 29);
            this.button3.TabIndex = 26;
            this.button3.Text = "Nome:";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 29);
            this.button4.TabIndex = 27;
            this.button4.Text = "Preço:";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(416, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 29);
            this.button5.TabIndex = 28;
            this.button5.Text = "Corte:";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(416, 114);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 29);
            this.button6.TabIndex = 29;
            this.button6.Text = "Descrição:";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(416, 157);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 29);
            this.button7.TabIndex = 30;
            this.button7.Text = "Hora:";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(786, 562);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_bucar_item);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_servico_Edit);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.txt_Hora);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_Descricao_Edit);
            this.Controls.Add(this.txt_Preco_Edit);
            this.Controls.Add(this.txt_Nome_Edit);
            this.Controls.Add(this.btn_salvar_alteracao);
            this.Controls.Add(this.tabela_dados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "menu";
            this.Text = "editar servicos";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela_dados;
        private System.Windows.Forms.Button btn_salvar_alteracao;
        private System.Windows.Forms.TextBox txt_Nome_Edit;
        private System.Windows.Forms.TextBox txt_Preco_Edit;
        private System.Windows.Forms.TextBox txt_Descricao_Edit;
        private System.Windows.Forms.DateTimePicker txt_data;
        private System.Windows.Forms.DateTimePicker txt_Hora;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_servico_Edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_bucar_item;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}