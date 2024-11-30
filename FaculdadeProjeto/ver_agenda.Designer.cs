
namespace FaculdadeProjeto
{
    partial class ver_agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ver_agenda));
            this.tabela_dados = new System.Windows.Forms.DataGridView();
            this.txt_Buscar_nome = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_Baixar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela_dados
            // 
            this.tabela_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dados.Location = new System.Drawing.Point(59, 67);
            this.tabela_dados.Name = "tabela_dados";
            this.tabela_dados.Size = new System.Drawing.Size(730, 335);
            this.tabela_dados.TabIndex = 1;
            // 
            // txt_Buscar_nome
            // 
            this.txt_Buscar_nome.Location = new System.Drawing.Point(77, 41);
            this.txt_Buscar_nome.Name = "txt_Buscar_nome";
            this.txt_Buscar_nome.Size = new System.Drawing.Size(136, 20);
            this.txt_Buscar_nome.TabIndex = 6;
            this.txt_Buscar_nome.TextChanged += new System.EventHandler(this.txt_Buscar_nome_TextChanged);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_voltar.BackgroundImage")));
            this.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar.ForeColor = System.Drawing.Color.White;
            this.btn_voltar.Location = new System.Drawing.Point(77, 439);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_Baixar
            // 
            this.btn_Baixar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Baixar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Baixar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Baixar.BackgroundImage")));
            this.btn_Baixar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Baixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Baixar.ForeColor = System.Drawing.Color.White;
            this.btn_Baixar.Location = new System.Drawing.Point(704, 425);
            this.btn_Baixar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Baixar.Name = "btn_Baixar";
            this.btn_Baixar.Size = new System.Drawing.Size(85, 37);
            this.btn_Baixar.TabIndex = 8;
            this.btn_Baixar.Text = "baixar";
            this.btn_Baixar.UseVisualStyleBackColor = false;
            this.btn_Baixar.Click += new System.EventHandler(this.btn_Baixar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(878, 474);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nome:";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(387, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Buscar Por:";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ver_agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(878, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Baixar);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.txt_Buscar_nome);
            this.Controls.Add(this.tabela_dados);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ver_agenda";
            this.Text = "ver_agenda";
            this.Load += new System.EventHandler(this.ver_agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela_dados;
        private System.Windows.Forms.TextBox txt_Buscar_nome;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_Baixar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}