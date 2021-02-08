namespace SorteadorMime
{
    partial class SorteadorMime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorteadorMime));
            this.upDownQtdSort = new System.Windows.Forms.NumericUpDown();
            this.lblE = new System.Windows.Forms.Label();
            this.lblNumEntre = new System.Windows.Forms.Label();
            this.lblSortear = new System.Windows.Forms.Label();
            this.lblLogoMime = new System.Windows.Forms.Label();
            this.upDownQtdFinal = new System.Windows.Forms.NumericUpDown();
            this.upDownQtdInicial = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGeraNumeros = new System.Windows.Forms.Button();
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.lblUltimoTexto = new System.Windows.Forms.Label();
            this.lblUltimoNumero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // upDownQtdSort
            // 
            this.upDownQtdSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQtdSort.Location = new System.Drawing.Point(226, 275);
            this.upDownQtdSort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upDownQtdSort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownQtdSort.Name = "upDownQtdSort";
            this.upDownQtdSort.Size = new System.Drawing.Size(228, 38);
            this.upDownQtdSort.TabIndex = 8;
            this.upDownQtdSort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDownQtdSort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(319, 400);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(30, 31);
            this.lblE.TabIndex = 12;
            this.lblE.Text = "e";
            // 
            // lblNumEntre
            // 
            this.lblNumEntre.AutoSize = true;
            this.lblNumEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEntre.Location = new System.Drawing.Point(230, 316);
            this.lblNumEntre.Name = "lblNumEntre";
            this.lblNumEntre.Size = new System.Drawing.Size(221, 31);
            this.lblNumEntre.TabIndex = 13;
            this.lblNumEntre.Text = "número(s) entre";
            // 
            // lblSortear
            // 
            this.lblSortear.AutoSize = true;
            this.lblSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortear.Location = new System.Drawing.Point(279, 239);
            this.lblSortear.Name = "lblSortear";
            this.lblSortear.Size = new System.Drawing.Size(126, 33);
            this.lblSortear.TabIndex = 14;
            this.lblSortear.Text = "Sortear ";
            // 
            // lblLogoMime
            // 
            this.lblLogoMime.Image = global::SorteadorMime.Properties.Resources.logo;
            this.lblLogoMime.Location = new System.Drawing.Point(9, 6);
            this.lblLogoMime.Name = "lblLogoMime";
            this.lblLogoMime.Size = new System.Drawing.Size(119, 42);
            this.lblLogoMime.TabIndex = 11;
            // 
            // upDownQtdFinal
            // 
            this.upDownQtdFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQtdFinal.Location = new System.Drawing.Point(226, 434);
            this.upDownQtdFinal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.upDownQtdFinal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownQtdFinal.Name = "upDownQtdFinal";
            this.upDownQtdFinal.Size = new System.Drawing.Size(225, 38);
            this.upDownQtdFinal.TabIndex = 9;
            this.upDownQtdFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDownQtdFinal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upDownQtdInicial
            // 
            this.upDownQtdInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQtdInicial.Location = new System.Drawing.Point(226, 359);
            this.upDownQtdInicial.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.upDownQtdInicial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownQtdInicial.Name = "upDownQtdInicial";
            this.upDownQtdInicial.Size = new System.Drawing.Size(225, 38);
            this.upDownQtdInicial.TabIndex = 10;
            this.upDownQtdInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.upDownQtdInicial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(223, 495);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(228, 38);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnGeraNumeros
            // 
            this.btnGeraNumeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.btnGeraNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeraNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraNumeros.Location = new System.Drawing.Point(12, 539);
            this.btnGeraNumeros.Name = "btnGeraNumeros";
            this.btnGeraNumeros.Size = new System.Drawing.Size(442, 44);
            this.btnGeraNumeros.TabIndex = 7;
            this.btnGeraNumeros.Text = "Sortear";
            this.btnGeraNumeros.UseVisualStyleBackColor = true;
            this.btnGeraNumeros.Click += new System.EventHandler(this.btnGeraNumeros_Click);
            // 
            // listaResultado
            // 
            this.listaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.ItemHeight = 25;
            this.listaResultado.Location = new System.Drawing.Point(12, 54);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(208, 479);
            this.listaResultado.TabIndex = 5;
            // 
            // lblUltimoTexto
            // 
            this.lblUltimoTexto.AutoSize = true;
            this.lblUltimoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoTexto.Location = new System.Drawing.Point(220, 86);
            this.lblUltimoTexto.Name = "lblUltimoTexto";
            this.lblUltimoTexto.Size = new System.Drawing.Size(248, 33);
            this.lblUltimoTexto.TabIndex = 15;
            this.lblUltimoTexto.Text = "Último Sorteado:";
            // 
            // lblUltimoNumero
            // 
            this.lblUltimoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.lblUltimoNumero.Location = new System.Drawing.Point(229, 119);
            this.lblUltimoNumero.Name = "lblUltimoNumero";
            this.lblUltimoNumero.Size = new System.Drawing.Size(228, 108);
            this.lblUltimoNumero.TabIndex = 16;
            this.lblUltimoNumero.Text = "-";
            this.lblUltimoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.lblTitulo.Location = new System.Drawing.Point(179, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 39);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Sorteador Mime";
            // 
            // SorteadorMime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(466, 595);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUltimoNumero);
            this.Controls.Add(this.lblUltimoTexto);
            this.Controls.Add(this.upDownQtdSort);
            this.Controls.Add(this.lblE);
            this.Controls.Add(this.lblNumEntre);
            this.Controls.Add(this.lblSortear);
            this.Controls.Add(this.lblLogoMime);
            this.Controls.Add(this.upDownQtdFinal);
            this.Controls.Add(this.upDownQtdInicial);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGeraNumeros);
            this.Controls.Add(this.listaResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorteadorMime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteador Mime";
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown upDownQtdSort;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblNumEntre;
        private System.Windows.Forms.Label lblSortear;
        private System.Windows.Forms.Label lblLogoMime;
        private System.Windows.Forms.NumericUpDown upDownQtdFinal;
        private System.Windows.Forms.NumericUpDown upDownQtdInicial;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnGeraNumeros;
        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Label lblUltimoTexto;
        private System.Windows.Forms.Label lblUltimoNumero;
        private System.Windows.Forms.Label lblTitulo;
    }
}

