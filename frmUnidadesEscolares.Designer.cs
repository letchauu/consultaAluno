namespace consultaAluno
{
    partial class frmUnidadesEscolares
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeEscola = new System.Windows.Forms.TextBox();
            this.txtEnderecoEscola = new System.Windows.Forms.TextBox();
            this.txtTelefoneEscola = new System.Windows.Forms.TextBox();
            this.btnSalvarCadEscola = new System.Windows.Forms.Button();
            this.txtCidadeEscola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Escola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço Escola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cidade Escola";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone Escola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(398, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cadastro de Escolas";
            // 
            // txtNomeEscola
            // 
            this.txtNomeEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeEscola.Location = new System.Drawing.Point(294, 160);
            this.txtNomeEscola.Name = "txtNomeEscola";
            this.txtNomeEscola.Size = new System.Drawing.Size(325, 26);
            this.txtNomeEscola.TabIndex = 5;
            this.txtNomeEscola.TextChanged += new System.EventHandler(this.txtNomeEscola_TextChanged);
            // 
            // txtEnderecoEscola
            // 
            this.txtEnderecoEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoEscola.Location = new System.Drawing.Point(294, 225);
            this.txtEnderecoEscola.Name = "txtEnderecoEscola";
            this.txtEnderecoEscola.Size = new System.Drawing.Size(325, 26);
            this.txtEnderecoEscola.TabIndex = 6;
            // 
            // txtTelefoneEscola
            // 
            this.txtTelefoneEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneEscola.Location = new System.Drawing.Point(294, 341);
            this.txtTelefoneEscola.Name = "txtTelefoneEscola";
            this.txtTelefoneEscola.Size = new System.Drawing.Size(325, 26);
            this.txtTelefoneEscola.TabIndex = 7;
            // 
            // btnSalvarCadEscola
            // 
            this.btnSalvarCadEscola.Location = new System.Drawing.Point(391, 412);
            this.btnSalvarCadEscola.Name = "btnSalvarCadEscola";
            this.btnSalvarCadEscola.Size = new System.Drawing.Size(125, 44);
            this.btnSalvarCadEscola.TabIndex = 9;
            this.btnSalvarCadEscola.Text = "Salvar";
            this.btnSalvarCadEscola.UseVisualStyleBackColor = true;
            this.btnSalvarCadEscola.Click += new System.EventHandler(this.btnSalvarCadEscola_Click);
            // 
            // txtCidadeEscola
            // 
            this.txtCidadeEscola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeEscola.Location = new System.Drawing.Point(294, 282);
            this.txtCidadeEscola.Name = "txtCidadeEscola";
            this.txtCidadeEscola.Size = new System.Drawing.Size(325, 26);
            this.txtCidadeEscola.TabIndex = 10;
            // 
            // frmUnidadesEscolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(890, 508);
            this.Controls.Add(this.txtCidadeEscola);
            this.Controls.Add(this.btnSalvarCadEscola);
            this.Controls.Add(this.txtTelefoneEscola);
            this.Controls.Add(this.txtEnderecoEscola);
            this.Controls.Add(this.txtNomeEscola);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUnidadesEscolares";
            this.Text = "Cadastro de Unidades Escolares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeEscola;
        private System.Windows.Forms.TextBox txtEnderecoEscola;
        private System.Windows.Forms.TextBox txtTelefoneEscola;
        private System.Windows.Forms.Button btnSalvarCadEscola;
        private System.Windows.Forms.TextBox txtCidadeEscola;
    }
}