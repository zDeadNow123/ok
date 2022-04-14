using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabNu;


namespace AuladeHoje {
    public partial class Produto2 : Form {
        public Produto2() {
            InitializeComponent();
        }

        private void btnRead_produto_Click(object sender, EventArgs e) {

            foreach (var item in Produto.ListarTodos()) {
                listProdutos.Items.Add($"ID: {item.Id}, DESCRIÇÃO: {item.Descricao}, UNIDADE: {item.Unidade}, CODBAR: {item.CodBar}, VALOR: {item.Valor}, DESCONTO: {item.Desconto}, DESCONTINUADO: {item.Descontinuado}");
            }

        }

        private void btnInserir_prod_Click(object sender, EventArgs e) {
            
            Produto produto = new Produto(
                txtDescricao_prod.Text,
                Double.Parse(txtUnidade_prod.Text),
                txtCodbar_prod.Text,
                Double.Parse(txtValor_prod.Text),
                Double.Parse(txtDesconto_prod.Text)
            );

            try {
                produto.Inserir();
                txtId_prod.Text = produto.Id.ToString();
                MessageBox.Show($"O Produto {produto.Descricao}\nfoi inserido com sucesso");

            } catch (MySql.Data.MySqlClient.MySqlException erro) {
                MessageBox.Show($"Plin plin plin, uma falha, foi detectada: {erro.Message}");
            }

        }
    }
}
