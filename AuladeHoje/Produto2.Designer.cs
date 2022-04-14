namespace AuladeHoje {
    partial class Produto2 {
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
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.btnRead_produto = new System.Windows.Forms.Button();
            this.txtId_prod = new System.Windows.Forms.TextBox();
            this.txtDescricao_prod = new System.Windows.Forms.TextBox();
            this.txtUnidade_prod = new System.Windows.Forms.TextBox();
            this.txtCodbar_prod = new System.Windows.Forms.TextBox();
            this.txtValor_prod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesconto_prod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInserir_prod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(347, 69);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(401, 186);
            this.listProdutos.TabIndex = 0;
            // 
            // btnRead_produto
            // 
            this.btnRead_produto.Location = new System.Drawing.Point(347, 272);
            this.btnRead_produto.Name = "btnRead_produto";
            this.btnRead_produto.Size = new System.Drawing.Size(75, 23);
            this.btnRead_produto.TabIndex = 1;
            this.btnRead_produto.Text = "READ";
            this.btnRead_produto.UseVisualStyleBackColor = true;
            this.btnRead_produto.Click += new System.EventHandler(this.btnRead_produto_Click);
            // 
            // txtId_prod
            // 
            this.txtId_prod.Location = new System.Drawing.Point(136, 69);
            this.txtId_prod.Name = "txtId_prod";
            this.txtId_prod.ReadOnly = true;
            this.txtId_prod.Size = new System.Drawing.Size(46, 20);
            this.txtId_prod.TabIndex = 2;
            // 
            // txtDescricao_prod
            // 
            this.txtDescricao_prod.Location = new System.Drawing.Point(136, 105);
            this.txtDescricao_prod.MaxLength = 100;
            this.txtDescricao_prod.Name = "txtDescricao_prod";
            this.txtDescricao_prod.Size = new System.Drawing.Size(181, 20);
            this.txtDescricao_prod.TabIndex = 3;
            // 
            // txtUnidade_prod
            // 
            this.txtUnidade_prod.Location = new System.Drawing.Point(136, 144);
            this.txtUnidade_prod.MaxLength = 14;
            this.txtUnidade_prod.Name = "txtUnidade_prod";
            this.txtUnidade_prod.Size = new System.Drawing.Size(181, 20);
            this.txtUnidade_prod.TabIndex = 4;
            // 
            // txtCodbar_prod
            // 
            this.txtCodbar_prod.Location = new System.Drawing.Point(136, 185);
            this.txtCodbar_prod.MaxLength = 13;
            this.txtCodbar_prod.Name = "txtCodbar_prod";
            this.txtCodbar_prod.Size = new System.Drawing.Size(181, 20);
            this.txtCodbar_prod.TabIndex = 5;
            // 
            // txtValor_prod
            // 
            this.txtValor_prod.Location = new System.Drawing.Point(136, 226);
            this.txtValor_prod.MaxLength = 10;
            this.txtValor_prod.Name = "txtValor_prod";
            this.txtValor_prod.Size = new System.Drawing.Size(181, 20);
            this.txtValor_prod.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "DESCRIÇÃO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "UNIDADE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CODBAR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "VALOR";
            // 
            // txtDesconto_prod
            // 
            this.txtDesconto_prod.Location = new System.Drawing.Point(136, 272);
            this.txtDesconto_prod.MaxLength = 10;
            this.txtDesconto_prod.Name = "txtDesconto_prod";
            this.txtDesconto_prod.Size = new System.Drawing.Size(181, 20);
            this.txtDesconto_prod.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "DESCONTO";
            // 
            // btnInserir_prod
            // 
            this.btnInserir_prod.Location = new System.Drawing.Point(136, 313);
            this.btnInserir_prod.Name = "btnInserir_prod";
            this.btnInserir_prod.Size = new System.Drawing.Size(75, 23);
            this.btnInserir_prod.TabIndex = 14;
            this.btnInserir_prod.Text = "Inserir";
            this.btnInserir_prod.UseVisualStyleBackColor = true;
            this.btnInserir_prod.Click += new System.EventHandler(this.btnInserir_prod_Click);
            // 
            // Produto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserir_prod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDesconto_prod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor_prod);
            this.Controls.Add(this.txtCodbar_prod);
            this.Controls.Add(this.txtUnidade_prod);
            this.Controls.Add(this.txtDescricao_prod);
            this.Controls.Add(this.txtId_prod);
            this.Controls.Add(this.btnRead_produto);
            this.Controls.Add(this.listProdutos);
            this.Name = "Produto2";
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Button btnRead_produto;
        private System.Windows.Forms.TextBox txtId_prod;
        private System.Windows.Forms.TextBox txtDescricao_prod;
        private System.Windows.Forms.TextBox txtUnidade_prod;
        private System.Windows.Forms.TextBox txtCodbar_prod;
        private System.Windows.Forms.TextBox txtValor_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesconto_prod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnInserir_prod;
    }
}