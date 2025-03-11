namespace consultaAluno
{
    partial class frmMatriculaAluno
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
            this.cmbNomeAluno = new System.Windows.Forms.ComboBox();
            this.cmbNomeCurso = new System.Windows.Forms.ComboBox();
            this.cmbStatusMatricula = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarMatricula = new System.Windows.Forms.Button();
            this.dtpDataMatricula2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnidadeEscolar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbNomeAluno
            // 
            this.cmbNomeAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeAluno.FormattingEnabled = true;
            this.cmbNomeAluno.Location = new System.Drawing.Point(316, 155);
            this.cmbNomeAluno.Name = "cmbNomeAluno";
            this.cmbNomeAluno.Size = new System.Drawing.Size(210, 28);
            this.cmbNomeAluno.TabIndex = 0;
            this.cmbNomeAluno.SelectedIndexChanged += new System.EventHandler(this.cmbNomeAluno_SelectedIndexChanged);
            // 
            // cmbNomeCurso
            // 
            this.cmbNomeCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNomeCurso.FormattingEnabled = true;
            this.cmbNomeCurso.Location = new System.Drawing.Point(316, 228);
            this.cmbNomeCurso.Name = "cmbNomeCurso";
            this.cmbNomeCurso.Size = new System.Drawing.Size(210, 28);
            this.cmbNomeCurso.TabIndex = 1;
            // 
            // cmbStatusMatricula
            // 
            this.cmbStatusMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatusMatricula.FormattingEnabled = true;
            this.cmbStatusMatricula.Items.AddRange(new object[] {
            "Ativa",
            "Cancelada",
            "Concluída"});
            this.cmbStatusMatricula.Location = new System.Drawing.Point(316, 378);
            this.cmbStatusMatricula.Name = "cmbStatusMatricula";
            this.cmbStatusMatricula.Size = new System.Drawing.Size(210, 28);
            this.cmbStatusMatricula.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(186, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data Matrícula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status Matrícula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(198, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 44);
            this.label5.TabIndex = 8;
            this.label5.Text = "Matricular Alunos";
            // 
            // btnSalvarMatricula
            // 
            this.btnSalvarMatricula.Location = new System.Drawing.Point(369, 499);
            this.btnSalvarMatricula.Name = "btnSalvarMatricula";
            this.btnSalvarMatricula.Size = new System.Drawing.Size(103, 31);
            this.btnSalvarMatricula.TabIndex = 9;
            this.btnSalvarMatricula.Text = "Salvar";
            this.btnSalvarMatricula.UseVisualStyleBackColor = true;
            this.btnSalvarMatricula.Click += new System.EventHandler(this.btnSalvarMatricula_Click);
            // 
            // dtpDataMatricula2
            // 
            this.dtpDataMatricula2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataMatricula2.Location = new System.Drawing.Point(316, 313);
            this.dtpDataMatricula2.Name = "dtpDataMatricula2";
            this.dtpDataMatricula2.Size = new System.Drawing.Size(210, 20);
            this.dtpDataMatricula2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(172, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Unidade Escolar";
            // 
            // cmbUnidadeEscolar
            // 
            this.cmbUnidadeEscolar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadeEscolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadeEscolar.FormattingEnabled = true;
            this.cmbUnidadeEscolar.Location = new System.Drawing.Point(316, 443);
            this.cmbUnidadeEscolar.Name = "cmbUnidadeEscolar";
            this.cmbUnidadeEscolar.Size = new System.Drawing.Size(210, 28);
            this.cmbUnidadeEscolar.TabIndex = 12;
            this.cmbUnidadeEscolar.SelectedIndexChanged += new System.EventHandler(this.cmbUnidadeEscolar_SelectedIndexChanged);
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(755, 585);
            this.Controls.Add(this.cmbUnidadeEscolar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDataMatricula2);
            this.Controls.Add(this.btnSalvarMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatusMatricula);
            this.Controls.Add(this.cmbNomeCurso);
            this.Controls.Add(this.cmbNomeAluno);
            this.Name = "frmMatriculaAluno";
            this.Text = "Matricular alunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNomeAluno;
        private System.Windows.Forms.ComboBox cmbNomeCurso;
        private System.Windows.Forms.ComboBox cmbStatusMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarMatricula;
        private System.Windows.Forms.DateTimePicker dtpDataMatricula2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnidadeEscolar;
    }
}