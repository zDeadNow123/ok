namespace AuladeHoje {
    partial class Usuario2 {
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
            this.txtNome_user = new System.Windows.Forms.TextBox();
            this.txtEmail_user = new System.Windows.Forms.TextBox();
            this.txtSenha_user = new System.Windows.Forms.TextBox();
            this.txtNivel_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir_user = new System.Windows.Forms.Button();
            this.listUser = new System.Windows.Forms.ListBox();
            this.btnRead_user = new System.Windows.Forms.Button();
            this.txtId_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome_user
            // 
            this.txtNome_user.Location = new System.Drawing.Point(105, 79);
            this.txtNome_user.MaxLength = 60;
            this.txtNome_user.Name = "txtNome_user";
            this.txtNome_user.Size = new System.Drawing.Size(197, 20);
            this.txtNome_user.TabIndex = 0;
            // 
            // txtEmail_user
            // 
            this.txtEmail_user.Location = new System.Drawing.Point(105, 121);
            this.txtEmail_user.MaxLength = 60;
            this.txtEmail_user.Name = "txtEmail_user";
            this.txtEmail_user.Size = new System.Drawing.Size(197, 20);
            this.txtEmail_user.TabIndex = 1;
            // 
            // txtSenha_user
            // 
            this.txtSenha_user.Location = new System.Drawing.Point(105, 166);
            this.txtSenha_user.MaxLength = 32;
            this.txtSenha_user.Name = "txtSenha_user";
            this.txtSenha_user.Size = new System.Drawing.Size(197, 20);
            this.txtSenha_user.TabIndex = 2;
            // 
            // txtNivel_user
            // 
            this.txtNivel_user.Location = new System.Drawing.Point(105, 204);
            this.txtNivel_user.MaxLength = 11;
            this.txtNivel_user.Name = "txtNivel_user";
            this.txtNivel_user.Size = new System.Drawing.Size(197, 20);
            this.txtNivel_user.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "EMAIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "SENHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIVEL";
            // 
            // btnInserir_user
            // 
            this.btnInserir_user.Location = new System.Drawing.Point(105, 241);
            this.btnInserir_user.Name = "btnInserir_user";
            this.btnInserir_user.Size = new System.Drawing.Size(75, 23);
            this.btnInserir_user.TabIndex = 8;
            this.btnInserir_user.Text = "INSERIR";
            this.btnInserir_user.UseVisualStyleBackColor = true;
            this.btnInserir_user.Click += new System.EventHandler(this.btnInserir_user_Click);
            // 
            // listUser
            // 
            this.listUser.FormattingEnabled = true;
            this.listUser.Location = new System.Drawing.Point(318, 79);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(795, 147);
            this.listUser.TabIndex = 9;
            // 
            // btnRead_user
            // 
            this.btnRead_user.Location = new System.Drawing.Point(318, 241);
            this.btnRead_user.Name = "btnRead_user";
            this.btnRead_user.Size = new System.Drawing.Size(75, 23);
            this.btnRead_user.TabIndex = 10;
            this.btnRead_user.Text = "READ";
            this.btnRead_user.UseVisualStyleBackColor = true;
            this.btnRead_user.Click += new System.EventHandler(this.btnRead_user_Click);
            // 
            // txtId_user
            // 
            this.txtId_user.Location = new System.Drawing.Point(105, 43);
            this.txtId_user.Name = "txtId_user";
            this.txtId_user.ReadOnly = true;
            this.txtId_user.Size = new System.Drawing.Size(50, 20);
            this.txtId_user.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID";
            // 
            // Usuario2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId_user);
            this.Controls.Add(this.btnRead_user);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.btnInserir_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNivel_user);
            this.Controls.Add(this.txtSenha_user);
            this.Controls.Add(this.txtEmail_user);
            this.Controls.Add(this.txtNome_user);
            this.Name = "Usuario2";
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome_user;
        private System.Windows.Forms.TextBox txtEmail_user;
        private System.Windows.Forms.TextBox txtSenha_user;
        private System.Windows.Forms.TextBox txtNivel_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInserir_user;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.Button btnRead_user;
        private System.Windows.Forms.TextBox txtId_user;
        private System.Windows.Forms.Label label5;
    }
}