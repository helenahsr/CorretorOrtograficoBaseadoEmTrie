namespace TrieOrtografica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dicionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePalavrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserirPalavra = new System.Windows.Forms.Button();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSugestao = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstPalavrasAdicionadas = new System.Windows.Forms.ListBox();
            this.bloquearInserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.dicionárioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // dicionárioToolStripMenuItem
            // 
            this.dicionárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePalavrasToolStripMenuItem,
            this.bloquearInserçãoToolStripMenuItem});
            this.dicionárioToolStripMenuItem.Name = "dicionárioToolStripMenuItem";
            this.dicionárioToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dicionárioToolStripMenuItem.Text = "Dicionário";
            // 
            // listaDePalavrasToolStripMenuItem
            // 
            this.listaDePalavrasToolStripMenuItem.Name = "listaDePalavrasToolStripMenuItem";
            this.listaDePalavrasToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listaDePalavrasToolStripMenuItem.Text = "Lista de Palavras";
            this.listaDePalavrasToolStripMenuItem.Click += new System.EventHandler(this.listaDePalavrasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeyDisplayString = "F1";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInserirPalavra);
            this.groupBox1.Controls.Add(this.txtPalavra);
            this.groupBox1.Controls.Add(this.lblPalavra);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserir palavras no dicionário";
            // 
            // btnInserirPalavra
            // 
            this.btnInserirPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirPalavra.Location = new System.Drawing.Point(10, 77);
            this.btnInserirPalavra.Name = "btnInserirPalavra";
            this.btnInserirPalavra.Size = new System.Drawing.Size(298, 33);
            this.btnInserirPalavra.TabIndex = 2;
            this.btnInserirPalavra.Text = "Inserir";
            this.btnInserirPalavra.UseVisualStyleBackColor = true;
            this.btnInserirPalavra.Click += new System.EventHandler(this.btnInserirPalavra_Click);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra.Location = new System.Drawing.Point(77, 45);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(231, 26);
            this.txtPalavra.TabIndex = 1;
            this.txtPalavra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalavra_KeyDown);
            this.txtPalavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalavra.Location = new System.Drawing.Point(6, 48);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(65, 20);
            this.lblPalavra.TabIndex = 0;
            this.lblPalavra.Text = "Palavra:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lstSugestao);
            this.groupBox2.Controls.Add(this.txtTexto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 275);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usar Corretor Ortográfico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sugestão:";
            // 
            // lstSugestao
            // 
            this.lstSugestao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSugestao.FormattingEnabled = true;
            this.lstSugestao.ItemHeight = 20;
            this.lstSugestao.Location = new System.Drawing.Point(10, 134);
            this.lstSugestao.Name = "lstSugestao";
            this.lstSugestao.Size = new System.Drawing.Size(315, 124);
            this.lstSugestao.TabIndex = 3;
            this.lstSugestao.DoubleClick += new System.EventHandler(this.lstSugestao_DoubleClick_1);
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(10, 54);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(315, 44);
            this.txtTexto.TabIndex = 2;
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seu texto:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstPalavrasAdicionadas);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(369, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 411);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dicionário";
            // 
            // lstPalavrasAdicionadas
            // 
            this.lstPalavrasAdicionadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPalavrasAdicionadas.FormattingEnabled = true;
            this.lstPalavrasAdicionadas.ItemHeight = 20;
            this.lstPalavrasAdicionadas.Location = new System.Drawing.Point(13, 31);
            this.lstPalavrasAdicionadas.Name = "lstPalavrasAdicionadas";
            this.lstPalavrasAdicionadas.Size = new System.Drawing.Size(390, 344);
            this.lstPalavrasAdicionadas.TabIndex = 0;
            // 
            // bloquearInserçãoToolStripMenuItem
            // 
            this.bloquearInserçãoToolStripMenuItem.CheckOnClick = true;
            this.bloquearInserçãoToolStripMenuItem.Name = "bloquearInserçãoToolStripMenuItem";
            this.bloquearInserçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bloquearInserçãoToolStripMenuItem.Text = "Bloquear inserção";
            this.bloquearInserçãoToolStripMenuItem.Click += new System.EventHandler(this.bloquearInserçãoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Corretor Ortográfico com Trie";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dicionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePalavrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Button btnInserirPalavra;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstPalavrasAdicionadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSugestao;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearInserçãoToolStripMenuItem;
    }
}

