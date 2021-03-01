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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorteadorMime));
            this.upDownQtdSort = new System.Windows.Forms.NumericUpDown();
            this.lblE = new System.Windows.Forms.Label();
            this.lblNumEntre = new System.Windows.Forms.Label();
            this.lblSortear = new System.Windows.Forms.Label();
            this.upDownQtdFinal = new System.Windows.Forms.NumericUpDown();
            this.upDownQtdInicial = new System.Windows.Forms.NumericUpDown();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnGeraNumeros = new System.Windows.Forms.Button();
            this.lblUltimoTexto = new System.Windows.Forms.Label();
            this.lblUltimoNumero = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblLogoMime = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportaExcel = new System.Windows.Forms.Button();
            this.lblTotalNumeros = new System.Windows.Forms.Label();
            this.lblQtdeTotal = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // upDownQtdSort
            // 
            this.upDownQtdSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQtdSort.Location = new System.Drawing.Point(1415, 275);
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
            this.lblE.Location = new System.Drawing.Point(1508, 400);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(30, 31);
            this.lblE.TabIndex = 12;
            this.lblE.Text = "e";
            // 
            // lblNumEntre
            // 
            this.lblNumEntre.AutoSize = true;
            this.lblNumEntre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEntre.Location = new System.Drawing.Point(1419, 316);
            this.lblNumEntre.Name = "lblNumEntre";
            this.lblNumEntre.Size = new System.Drawing.Size(221, 31);
            this.lblNumEntre.TabIndex = 13;
            this.lblNumEntre.Text = "número(s) entre";
            // 
            // lblSortear
            // 
            this.lblSortear.AutoSize = true;
            this.lblSortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortear.Location = new System.Drawing.Point(1468, 239);
            this.lblSortear.Name = "lblSortear";
            this.lblSortear.Size = new System.Drawing.Size(126, 33);
            this.lblSortear.TabIndex = 14;
            this.lblSortear.Text = "Sortear ";
            // 
            // upDownQtdFinal
            // 
            this.upDownQtdFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQtdFinal.Location = new System.Drawing.Point(1415, 434);
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
            this.upDownQtdFinal.ValueChanged += new System.EventHandler(this.upDownQtdFinal_ValueChanged);
            // 
            // upDownQtdInicial
            // 
            this.upDownQtdInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upDownQtdInicial.Location = new System.Drawing.Point(1415, 359);
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
            this.btnLimpar.Location = new System.Drawing.Point(1412, 490);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(228, 43);
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
            this.btnGeraNumeros.Size = new System.Drawing.Size(1380, 44);
            this.btnGeraNumeros.TabIndex = 7;
            this.btnGeraNumeros.Text = "Sortear";
            this.btnGeraNumeros.UseVisualStyleBackColor = true;
            this.btnGeraNumeros.Click += new System.EventHandler(this.btnGeraNumeros_Click);
            // 
            // lblUltimoTexto
            // 
            this.lblUltimoTexto.AutoSize = true;
            this.lblUltimoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoTexto.Location = new System.Drawing.Point(1406, 51);
            this.lblUltimoTexto.Name = "lblUltimoTexto";
            this.lblUltimoTexto.Size = new System.Drawing.Size(248, 33);
            this.lblUltimoTexto.TabIndex = 15;
            this.lblUltimoTexto.Text = "Último Sorteado:";
            // 
            // lblUltimoNumero
            // 
            this.lblUltimoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.lblUltimoNumero.Location = new System.Drawing.Point(1415, 89);
            this.lblUltimoNumero.Name = "lblUltimoNumero";
            this.lblUltimoNumero.Size = new System.Drawing.Size(228, 52);
            this.lblUltimoNumero.TabIndex = 16;
            this.lblUltimoNumero.Text = "-";
            this.lblUltimoNumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.lblTitulo.Location = new System.Drawing.Point(176, -3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(969, 51);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Sorteador Mime";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogoMime
            // 
            this.lblLogoMime.Image = global::SorteadorMime.Properties.Resources.logo;
            this.lblLogoMime.Location = new System.Drawing.Point(9, 6);
            this.lblLogoMime.Name = "lblLogoMime";
            this.lblLogoMime.Size = new System.Drawing.Size(119, 42);
            this.lblLogoMime.TabIndex = 11;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDados.ColumnHeadersHeight = 60;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nome,
            this.Cargo,
            this.Filial});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDados.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDados.Location = new System.Drawing.Point(12, 51);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(1380, 479);
            this.dgvDados.TabIndex = 18;
            // 
            // Numero
            // 
            this.Numero.Frozen = true;
            this.Numero.HeaderText = "Núm.";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.Frozen = true;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 560;
            // 
            // Cargo
            // 
            this.Cargo.Frozen = true;
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 300;
            // 
            // Filial
            // 
            this.Filial.Frozen = true;
            this.Filial.HeaderText = "Filial";
            this.Filial.Name = "Filial";
            this.Filial.ReadOnly = true;
            this.Filial.Width = 375;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // btnImportaExcel
            // 
            this.btnImportaExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnImportaExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(36)))), ((int)(((byte)(65)))));
            this.btnImportaExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportaExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportaExcel.Location = new System.Drawing.Point(1412, 539);
            this.btnImportaExcel.Name = "btnImportaExcel";
            this.btnImportaExcel.Size = new System.Drawing.Size(228, 44);
            this.btnImportaExcel.TabIndex = 19;
            this.btnImportaExcel.Text = "Importar Excel";
            this.btnImportaExcel.UseVisualStyleBackColor = true;
            this.btnImportaExcel.Click += new System.EventHandler(this.btnImportaExcel_Click);
            // 
            // lblTotalNumeros
            // 
            this.lblTotalNumeros.AutoSize = true;
            this.lblTotalNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNumeros.Location = new System.Drawing.Point(1420, 154);
            this.lblTotalNumeros.Name = "lblTotalNumeros";
            this.lblTotalNumeros.Size = new System.Drawing.Size(230, 29);
            this.lblTotalNumeros.TabIndex = 20;
            this.lblTotalNumeros.Text = "Total de Números:";
            // 
            // lblQtdeTotal
            // 
            this.lblQtdeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdeTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQtdeTotal.Location = new System.Drawing.Point(1415, 183);
            this.lblQtdeTotal.Name = "lblQtdeTotal";
            this.lblQtdeTotal.Size = new System.Drawing.Size(228, 40);
            this.lblQtdeTotal.TabIndex = 21;
            this.lblQtdeTotal.Text = "-";
            this.lblQtdeTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SorteadorMime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1669, 595);
            this.Controls.Add(this.lblQtdeTotal);
            this.Controls.Add(this.lblTotalNumeros);
            this.Controls.Add(this.btnImportaExcel);
            this.Controls.Add(this.dgvDados);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SorteadorMime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteador Mime";
            this.Load += new System.EventHandler(this.SorteadorMime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownQtdInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
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
        private System.Windows.Forms.Label lblUltimoTexto;
        private System.Windows.Forms.Label lblUltimoNumero;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filial;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnImportaExcel;
        private System.Windows.Forms.Label lblTotalNumeros;
        private System.Windows.Forms.Label lblQtdeTotal;
        private System.Windows.Forms.Timer timer;
    }
}

