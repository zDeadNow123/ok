namespace AuladeHoje {
    partial class Tipo2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtNome_tipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSigla_tipo = new System.Windows.Forms.TextBox();
            this.btnCadastrar_tipo = new System.Windows.Forms.Button();
            this.lstTipo = new System.Windows.Forms.ListBox();
            this.txtId_tipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnListar_tipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome_tipo
            // 
            this.txtNome_tipo.Location = new System.Drawing.Point(28, 194);
            this.txtNome_tipo.Name = "txtNome_tipo";
            this.txtNome_tipo.Size = new System.Drawing.Size(211, 20);
            this.txtNome_tipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRO DE CATEGORIA DE PRODUTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SIGLA";
            // 
            // txtSigla_tipo
            // 
            this.txtSigla_tipo.Location = new System.Drawing.Point(28, 243);
            this.txtSigla_tipo.Name = "txtSigla_tipo";
            this.txtSigla_tipo.Size = new System.Drawing.Size(211, 20);
            this.txtSigla_tipo.TabIndex = 4;
            // 
            // btnCadastrar_tipo
            // 
            this.btnCadastrar_tipo.Location = new System.Drawing.Point(88, 280);
            this.btnCadastrar_tipo.Name = "btnCadastrar_tipo";
            this.btnCadastrar_tipo.Size = new System.Drawing.Size(89, 23);
            this.btnCadastrar_tipo.TabIndex = 5;
            this.btnCadastrar_tipo.Text = "CADASTRAR";
            this.btnCadastrar_tipo.UseVisualStyleBackColor = true;
            this.btnCadastrar_tipo.Click += new System.EventHandler(this.btnCadastrar_tipo_Click);
            // 
            // lstTipo
            // 
            this.lstTipo.FormattingEnabled = true;
            this.lstTipo.Location = new System.Drawing.Point(275, 94);
            this.lstTipo.Name = "lstTipo";
            this.lstTipo.Size = new System.Drawing.Size(350, 173);
            this.lstTipo.TabIndex = 6;
            // 
            // txtId_tipo
            // 
            this.txtId_tipo.Location = new System.Drawing.Point(28, 146);
            this.txtId_tipo.Name = "txtId_tipo";
            this.txtId_tipo.ReadOnly = true;
            this.txtId_tipo.Size = new System.Drawing.Size(46, 20);
            this.txtId_tipo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // btnListar_tipo
            // 
            this.btnListar_tipo.Location = new System.Drawing.Point(275, 280);
            this.btnListar_tipo.Name = "btnListar_tipo";
            this.btnListar_tipo.Size = new System.Drawing.Size(75, 23);
            this.btnListar_tipo.TabIndex = 9;
            this.btnListar_tipo.Text = "Listar";
            this.btnListar_tipo.UseVisualStyleBackColor = true;
            this.btnListar_tipo.Click += new System.EventHandler(this.btnListar_tipo_Click);
            // 
            // Tipo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.btnListar_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId_tipo);
            this.Controls.Add(this.lstTipo);
            this.Controls.Add(this.btnCadastrar_tipo);
            this.Controls.Add(this.txtSigla_tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome_tipo);
            this.Name = "Tipo2";
            this.Text = "Tipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSigla_tipo;
        private System.Windows.Forms.Button btnCadastrar_tipo;
        private System.Windows.Forms.ListBox lstTipo;
        private System.Windows.Forms.TextBox txtId_tipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnListar_tipo;
    }
}