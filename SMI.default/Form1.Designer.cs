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
            this.tpDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoDetalhamento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoPremissa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.campoRestricoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campoKeyUsr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // br_criar
            // 
            this.br_criar.Location = new System.Drawing.Point(12, 424);
            this.br_criar.Name = "br_criar";
            this.br_criar.Size = new System.Drawing.Size(75, 23);
            this.br_criar.TabIndex = 19;
            this.br_criar.Text = "Create";
            this.br_criar.UseVisualStyleBackColor = true;
            this.br_criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº SMI:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n_smi
            // 
            this.n_smi.Location = new System.Drawing.Point(92, 39);
            this.n_smi.Name = "n_smi";
            this.n_smi.Size = new System.Drawing.Size(62, 20);
            this.n_smi.TabIndex = 12;
            this.n_smi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Criacao:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // data_criacao
            // 
            this.data_criacao.Location = new System.Drawing.Point(92, 65);
            this.data_criacao.Mask = "00/00/0000";
            this.data_criacao.Name = "data_criacao";
            this.data_criacao.Size = new System.Drawing.Size(100, 20);
            this.data_criacao.TabIndex = 13;
            this.data_criacao.ValidatingType = typeof(System.DateTime);
            this.data_criacao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tp. Documento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.Location = new System.Drawing.Point(266, 424);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(75, 23);
            this.bt_fechar.TabIndex = 20;
            this.bt_fechar.Text = "Close";
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.button2_Click);
            // 
            // tituloSmi
            // 
            this.tituloSmi.Location = new System.Drawing.Point(92, 91);
            this.tituloSmi.Multiline = true;
            this.tituloSmi.Name = "tituloSmi";
            this.tituloSmi.Size = new System.Drawing.Size(238, 46);
            this.tituloSmi.TabIndex = 14;
            this.tituloSmi.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Titulo SMI:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tpDocumento
            // 
            this.tpDocumento.FormattingEnabled = true;
            this.tpDocumento.Items.AddRange(new object[] {
            "E.T",
            "H.F"});
            this.tpDocumento.Location = new System.Drawing.Point(92, 12);
            this.tpDocumento.Name = "tpDocumento";
            this.tpDocumento.Size = new System.Drawing.Size(62, 21);
            this.tpDocumento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalhamento:";
            // 
            // campoDetalhamento
            // 
            this.campoDetalhamento.Location = new System.Drawing.Point(92, 143);
            this.campoDetalhamento.Multiline = true;
            this.campoDetalhamento.Name = "campoDetalhamento";
            this.campoDetalhamento.Size = new System.Drawing.Size(238, 46);
            this.campoDetalhamento.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Premissa:";
            // 
            // campoPremissa
            // 
            this.campoPremissa.Location = new System.Drawing.Point(92, 195);
            this.campoPremissa.Multiline = true;
            this.campoPremissa.Name = "campoPremissa";
            this.campoPremissa.Size = new System.Drawing.Size(238, 46);
            this.campoPremissa.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Restrições:";
            // 
            // campoRestricoes
            // 
            this.campoRestricoes.Location = new System.Drawing.Point(92, 247);
            this.campoRestricoes.Multiline = true;
            this.campoRestricoes.Name = "campoRestricoes";
            this.campoRestricoes.Size = new System.Drawing.Size(238, 46);
            this.campoRestricoes.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Key Users:";
            // 
            // campoKeyUsr
            // 
            this.campoKeyUsr.Location = new System.Drawing.Point(92, 299);
            this.campoKeyUsr.Multiline = true;
            this.campoKeyUsr.Name = "campoKeyUsr";
            this.campoKeyUsr.Size = new System.Drawing.Size(238, 46);
            this.campoKeyUsr.TabIndex = 18;
            this.campoKeyUsr.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 459);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoKeyUsr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.campoRestricoes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoPremissa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoDetalhamento);
            this.Controls.Add(this.tpDocumento);
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
        private System.Windows.Forms.ComboBox tpDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoDetalhamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoPremissa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoRestricoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoKeyUsr;
    }
}

