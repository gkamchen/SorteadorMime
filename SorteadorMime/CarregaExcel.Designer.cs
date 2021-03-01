namespace SorteadorMime
{
    partial class CarregaExcel
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
            this.btnLocalizaArquivoExcel = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportaExcel = new System.Windows.Forms.Button();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.cboBusca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFiltraGanhador = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizaArquivoExcel
            // 
            this.btnLocalizaArquivoExcel.Location = new System.Drawing.Point(331, 646);
            this.btnLocalizaArquivoExcel.Name = "btnLocalizaArquivoExcel";
            this.btnLocalizaArquivoExcel.Size = new System.Drawing.Size(31, 26);
            this.btnLocalizaArquivoExcel.TabIndex = 20;
            this.btnLocalizaArquivoExcel.Text = "...";
            this.btnLocalizaArquivoExcel.UseVisualStyleBackColor = true;
            this.btnLocalizaArquivoExcel.Click += new System.EventHandler(this.btnLocalizaArquivoExcel_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.BackColor = System.Drawing.Color.White;
            this.lblRegistros.Location = new System.Drawing.Point(636, 652);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(74, 20);
            this.lblRegistros.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 652);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "No.  Registros ";
            // 
            // btnImportaExcel
            // 
            this.btnImportaExcel.Location = new System.Drawing.Point(381, 645);
            this.btnImportaExcel.Name = "btnImportaExcel";
            this.btnImportaExcel.Size = new System.Drawing.Size(126, 27);
            this.btnImportaExcel.TabIndex = 17;
            this.btnImportaExcel.Text = "Importar Excel";
            this.btnImportaExcel.UseVisualStyleBackColor = true;
            this.btnImportaExcel.Click += new System.EventHandler(this.btnImportaExcel_Click);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Location = new System.Drawing.Point(21, 645);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(310, 20);
            this.txtArquivoExcel.TabIndex = 16;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(21, 62);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(1032, 576);
            this.dgvDados.TabIndex = 15;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(611, 18);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(101, 28);
            this.btnExibirTodos.TabIndex = 13;
            this.btnExibirTodos.Text = "Exibir Todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(504, 18);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(101, 28);
            this.btnProcurar.TabIndex = 14;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(317, 18);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(181, 20);
            this.txtCriterio.TabIndex = 12;
            // 
            // cboBusca
            // 
            this.cboBusca.FormattingEnabled = true;
            this.cboBusca.Location = new System.Drawing.Point(121, 18);
            this.cboBusca.Name = "cboBusca";
            this.cboBusca.Size = new System.Drawing.Size(189, 21);
            this.cboBusca.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Procurar Por :";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // btnFiltraGanhador
            // 
            this.btnFiltraGanhador.Location = new System.Drawing.Point(788, 20);
            this.btnFiltraGanhador.Name = "btnFiltraGanhador";
            this.btnFiltraGanhador.Size = new System.Drawing.Size(75, 23);
            this.btnFiltraGanhador.TabIndex = 21;
            this.btnFiltraGanhador.Text = "button1";
            this.btnFiltraGanhador.UseVisualStyleBackColor = true;
            this.btnFiltraGanhador.Click += new System.EventHandler(this.btnFiltraGanhador_Click);
            // 
            // CarregaExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 681);
            this.Controls.Add(this.btnFiltraGanhador);
            this.Controls.Add(this.btnLocalizaArquivoExcel);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportaExcel);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.cboBusca);
            this.Controls.Add(this.label1);
            this.Name = "CarregaExcel";
            this.Text = "CarregaExcel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizaArquivoExcel;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportaExcel;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.ComboBox cboBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnFiltraGanhador;
    }
}