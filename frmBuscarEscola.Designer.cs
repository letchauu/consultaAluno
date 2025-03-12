namespace consultaAluno
{
    partial class frmBuscarEscola
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarEscola = new System.Windows.Forms.TextBox();
            this.btnBuscarEscola = new System.Windows.Forms.Button();
            this.dgvBuscarEscola = new System.Windows.Forms.DataGridView();
            this.btnTodasEscolas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEscola)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escola";
            // 
            // txtBuscarEscola
            // 
            this.txtBuscarEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEscola.Location = new System.Drawing.Point(186, 49);
            this.txtBuscarEscola.Name = "txtBuscarEscola";
            this.txtBuscarEscola.Size = new System.Drawing.Size(385, 26);
            this.txtBuscarEscola.TabIndex = 1;
            // 
            // btnBuscarEscola
            // 
            this.btnBuscarEscola.Location = new System.Drawing.Point(592, 45);
            this.btnBuscarEscola.Name = "btnBuscarEscola";
            this.btnBuscarEscola.Size = new System.Drawing.Size(98, 36);
            this.btnBuscarEscola.TabIndex = 2;
            this.btnBuscarEscola.Text = "Buscar";
            this.btnBuscarEscola.UseVisualStyleBackColor = true;
            this.btnBuscarEscola.Click += new System.EventHandler(this.btnBuscarEscola_Click);
            // 
            // dgvBuscarEscola
            // 
            this.dgvBuscarEscola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarEscola.Location = new System.Drawing.Point(129, 122);
            this.dgvBuscarEscola.Name = "dgvBuscarEscola";
            this.dgvBuscarEscola.Size = new System.Drawing.Size(561, 226);
            this.dgvBuscarEscola.TabIndex = 3;
            // 
            // btnTodasEscolas
            // 
            this.btnTodasEscolas.Location = new System.Drawing.Point(102, 379);
            this.btnTodasEscolas.Name = "btnTodasEscolas";
            this.btnTodasEscolas.Size = new System.Drawing.Size(143, 49);
            this.btnTodasEscolas.TabIndex = 4;
            this.btnTodasEscolas.Text = "Consultar todas escolas";
            this.btnTodasEscolas.UseVisualStyleBackColor = true;
            this.btnTodasEscolas.Click += new System.EventHandler(this.btnTodasEscolas_Click);
            // 
            // frmBuscarEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 474);
            this.Controls.Add(this.btnTodasEscolas);
            this.Controls.Add(this.dgvBuscarEscola);
            this.Controls.Add(this.btnBuscarEscola);
            this.Controls.Add(this.txtBuscarEscola);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarEscola";
            this.Text = "Buscar Escola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEscola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarEscola;
        private System.Windows.Forms.Button btnBuscarEscola;
        private System.Windows.Forms.DataGridView dgvBuscarEscola;
        private System.Windows.Forms.Button btnTodasEscolas;
    }
}