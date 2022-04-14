using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // não precisa, só usar como Var
using ClassLabNu;

namespace AuladeHoje {
    public partial class Cliente2 : Form {
        public Cliente2() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);

            try {
                cliente.Inserir();
                MessageBox.Show($"O Cliente {cliente.Nome}\nfoi gravado com sucesso!");


            }
            catch (MySql.Data.MySqlClient.MySqlException erro) {
                MessageBox.Show($"Erro! {erro.Message}");
                //("Falha na inserção. Não foi possível gravar dados corretamente!");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e) {

        }

        private void btnListar_Click(object sender, EventArgs e) {
            lstClientes.Items.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();
            foreach (Cliente cliente in listaDeClientes) {
                lstClientes.Items.Add($"ID: {cliente.Id} NOME: {cliente.Nome} CPF: {cliente.Cpf}");
            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
