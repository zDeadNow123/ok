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
            
            dgvClientes.Rows.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();

            for(int i = 0; i < listaDeClientes.Count; i++) {
                dgvClientes.Rows.Add(
                    listaDeClientes[i].Id,
                    listaDeClientes[i].Nome,
                    listaDeClientes[i].Cpf,
                    listaDeClientes[i].Email,
                    listaDeClientes[i].Ativo
                );
            }

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnBuscar_Click(object sender, EventArgs e) {

            if (btnBuscar.Text != "...") goto up;
            if (btnBuscar.Text == "...") goto down;

            up:
            Cliente qualquercoisa = Cliente.ConsultarPorId(int.Parse(txtId.Text));

            try {
                txtNome.Text = qualquercoisa.Nome.ToString();
                txtCpf.Text = qualquercoisa.Cpf.ToString();
                txtEmail.Text = qualquercoisa.Email.ToString();
                dtpDatacad.Text = qualquercoisa.DataCad.ToString();
                chkAtivo.Checked = qualquercoisa.Ativo;

                btnBuscar.Text = "...";
                txtId.ReadOnly = true;
                txtCpf.ReadOnly = false;
                btnAlterar.Enabled = false;

            }

            catch { }

            return;



            down:
            txtId.ReadOnly = false;
            btnAlterar.Enabled = true;
            txtCpf.ReadOnly = true;
            txtId.Focus();
            btnBuscar.Text = "Buscar";
            /*
            if (btnBuscar.Text == "...") {
                txtId.ReadOnly = false;
                txtId.Focus();
                btnBuscar.Text = "Buscar";
            } else {

                Cliente qualquercoisa = Cliente.ConsultarPorId(int.Parse(txtId.Text));

                try {

                }
                catch {}
            }
            */

        }

        private void btnAlterar_Click(object sender, EventArgs e) {

            Cliente cliente = new Cliente();

            if(cliente.Alterar(int.Parse(txtId.Text), txtNome.Text, txtEmail.Text)) {
                MessageBox.Show("Cliente alterado com sucesso!");

            } else {
                MessageBox.Show("Falha na alteração!");
            }

        }

    }
}
