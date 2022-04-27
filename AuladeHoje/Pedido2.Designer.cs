namespace AuladeHoje
{
    partial class Pedido2
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
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.txtIdList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dtgListar = new System.Windows.Forms.DataGridView();
            this.chkAlterar = new System.Windows.Forms.CheckBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.cmbCli = new System.Windows.Forms.ComboBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(109, 322);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(163, 21);
            this.cmbUsers.TabIndex = 0;
            // 
            // txtIdList
            // 
            this.txtIdList.Location = new System.Drawing.Point(42, 322);
            this.txtIdList.Name = "txtIdList";
            this.txtIdList.ReadOnly = true;
            this.txtIdList.Size = new System.Drawing.Size(53, 20);
            this.txtIdList.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(118, 124);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(154, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(42, 221);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Criar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(118, 161);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(154, 20);
            this.txtDesconto.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desconto:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(42, 367);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(53, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // dtgListar
            // 
            this.dtgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListar.Location = new System.Drawing.Point(309, 53);
            this.dtgListar.Name = "dtgListar";
            this.dtgListar.Size = new System.Drawing.Size(240, 194);
            this.dtgListar.TabIndex = 14;
            // 
            // chkAlterar
            // 
            this.chkAlterar.AutoSize = true;
            this.chkAlterar.Location = new System.Drawing.Point(216, 222);
            this.chkAlterar.Name = "chkAlterar";
            this.chkAlterar.Size = new System.Drawing.Size(56, 17);
            this.chkAlterar.TabIndex = 15;
            this.chkAlterar.Text = "Alterar";
            this.chkAlterar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(309, 268);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar Pedidos";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // cmbCli
            // 
            this.cmbCli.FormattingEnabled = true;
            this.cmbCli.Location = new System.Drawing.Point(118, 53);
            this.cmbCli.Name = "cmbCli";
            this.cmbCli.Size = new System.Drawing.Size(154, 21);
            this.cmbCli.TabIndex = 17;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(118, 88);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(154, 21);
            this.cmbUser.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(337, 376);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "label5";
            // 
            // Pedido2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.cmbCli);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.chkAlterar);
            this.Controls.Add(this.dtgListar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdList);
            this.Controls.Add(this.cmbUsers);
            this.Name = "Pedido2";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.TextBox txtIdList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dtgListar;
        private System.Windows.Forms.CheckBox chkAlterar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cmbCli;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lblStatus;
    }
}