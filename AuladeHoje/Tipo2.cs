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
    public partial class Tipo2 : Form {
        public Tipo2() {
            InitializeComponent();
        }

        private void btnCadastrar_tipo_Click(object sender, EventArgs e) {

            Tipo tipo = new Tipo(txtNome_tipo.Text, txtSigla_tipo.Text);

            try {
                tipo.Inserir();
                txtId_tipo.Text = tipo.Id.ToString();
                MessageBox.Show($"O Produto {tipo.Nome}\nfoi inserido com sucesso");

            }
            catch (MySql.Data.MySqlClient.MySqlException erro) {
                MessageBox.Show($"Plin plin plin, uma falha, foi detectada: {erro.Message}");
            }


        }

        private void btnListar_tipo_Click(object sender, EventArgs e) {

            foreach (var item in Tipo.ListarTodos()) {
                lstTipo.Items.Add($"ID: {item.Id}, NOME: {item.Nome}, SIGLA: {item.Sigla}");
            }

        }
    }
}
