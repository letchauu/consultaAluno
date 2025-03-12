namespace consultaAluno
{
    partial class frmBuscarCurso
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
            this.dgvBuscarCurso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.btnTodosCursos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarCurso
            // 
            this.dgvBuscarCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCurso.Location = new System.Drawing.Point(163, 126);
            this.dgvBuscarCurso.Name = "dgvBuscarCurso";
            this.dgvBuscarCurso.Size = new System.Drawing.Size(511, 241);
            this.dgvBuscarCurso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Curso";
            // 
            // txtBuscarCurso
            // 
            this.txtBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCurso.Location = new System.Drawing.Point(200, 62);
            this.txtBuscarCurso.Name = "txtBuscarCurso";
            this.txtBuscarCurso.Size = new System.Drawing.Size(396, 26);
            this.txtBuscarCurso.TabIndex = 2;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCurso.Location = new System.Drawing.Point(614, 60);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(82, 32);
            this.btnBuscarCurso.TabIndex = 3;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.btnBuscarCurso_Click);
            // 
            // btnTodosCursos
            // 
            this.btnTodosCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodosCursos.Location = new System.Drawing.Point(140, 399);
            this.btnTodosCursos.Name = "btnTodosCursos";
            this.btnTodosCursos.Size = new System.Drawing.Size(144, 45);
            this.btnTodosCursos.TabIndex = 4;
            this.btnTodosCursos.Text = "Mostrar todos os cursos";
            this.btnTodosCursos.UseVisualStyleBackColor = true;
            this.btnTodosCursos.Click += new System.EventHandler(this.btnTodosCursos_Click);
            // 
            // frmBuscarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::consultaAluno.Properties.Resources._29_wallpaper;
            this.ClientSize = new System.Drawing.Size(859, 506);
            this.Controls.Add(this.btnTodosCursos);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.txtBuscarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarCurso);
            this.Name = "frmBuscarCurso";
            this.Text = "Buscar Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarCurso;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.Button btnTodosCursos;
    }
}