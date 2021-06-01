namespace SMI.@default {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.br_criar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.n_smi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.data_criacao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.tituloSmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // br_criar
            // 
            this.br_criar.Location = new System.Drawing.Point(266, 424);
            this.br_criar.Name = "br_criar";
            this.br_criar.Size = new System.Drawing.Size(75, 23);
            this.br_criar.TabIndex = 0;
            this.br_criar.Text = "Criar";
            this.br_criar.UseVisualStyleBackColor = true;
            this.br_criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº SMI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n_smi
            // 
            this.n_smi.Location = new System.Drawing.Point(89, 37);
            this.n_smi.Name = "n_smi";
            this.n_smi.Size = new System.Drawing.Size(62, 20);
            this.n_smi.TabIndex = 3;
            this.n_smi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Criacao:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // data_criacao
            // 
            this.data_criacao.Location = new System.Drawing.Point(89, 66);
            this.data_criacao.Mask = "00/00/0000";
            this.data_criacao.Name = "data_criacao";
            this.data_criacao.Size = new System.Drawing.Size(100, 20);
            this.data_criacao.TabIndex = 6;
            this.data_criacao.ValidatingType = typeof(System.DateTime);
            this.data_criacao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Especificação Técnica";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(15, 424);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 8;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tituloSmi
            // 
            this.tituloSmi.Location = new System.Drawing.Point(89, 92);
            this.tituloSmi.Multiline = true;
            this.tituloSmi.Name = "tituloSmi";
            this.tituloSmi.Size = new System.Drawing.Size(238, 46);
            this.tituloSmi.TabIndex = 9;
            this.tituloSmi.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Titulo SMI:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tituloSmi);
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_criacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_smi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.br_criar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SMI Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button br_criar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_smi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox data_criacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_fechar;
        private System.Windows.Forms.TextBox tituloSmi;
        private System.Windows.Forms.Label label4;
    }
}

