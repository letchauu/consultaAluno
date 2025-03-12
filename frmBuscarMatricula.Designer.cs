namespace consultaAluno
{
    partial class frmBuscarMatricula
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
            this.txtBuscarMatricula = new System.Windows.Forms.TextBox();
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // txtBuscarMatricula
            // 
            this.txtBuscarMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarMatricula.Location = new System.Drawing.Point(228, 67);
            this.txtBuscarMatricula.Name = "txtBuscarMatricula";
            this.txtBuscarMatricula.Size = new System.Drawing.Size(337, 26);
            this.txtBuscarMatricula.TabIndex = 1;
            // 
            // btnBuscarMatricula
            // 
            this.btnBuscarMatricula.Location = new System.Drawing.Point(583, 64);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(96, 35);
            this.btnBuscarMatricula.TabIndex = 2;
            this.btnBuscarMatricula.Text = "Buscar";
            this.btnBuscarMatricula.UseVisualStyleBackColor = true;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmBuscarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::consultaAluno.Properties.Resources._2960590_abstrato_aquarela_textura_papel_de_parede_fundo_vetor;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarMatricula);
            this.Controls.Add(this.txtBuscarMatricula);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscarMatricula";
            this.Text = "Buscar Matrícula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarMatricula;
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}