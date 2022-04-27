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

namespace AuladeHoje
{
    public partial class Cliente2 : Form
    {
        public Cliente2()
        {
            InitializeComponent();
            cmbEstado.DropDownStyle = ComboBoxStyle.Simple;
            cmbEstado.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);

            try
            {
                cliente.Inserir();
                MessageBox.Show($"O Cliente {cliente.Nome}\nfoi gravado com sucesso!");


            }
            catch (MySql.Data.MySqlClient.MySqlException erro)
            {
                MessageBox.Show($"Erro! {erro.Message}");
                //("Falha na inserção. Não foi possível gravar dados corretamente!");
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            dgvClientes.Rows.Clear();
            List<Cliente> listaDeClientes = Cliente.Listar();

            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                dgvClientes.Rows.Add(
                    listaDeClientes[i].Id,
                    listaDeClientes[i].Nome,
                    listaDeClientes[i].Cpf,
                    listaDeClientes[i].Email,
                    listaDeClientes[i].Ativo
                );
            }

        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (btnBuscar.Text != "...") goto up;
            if (btnBuscar.Text == "...") goto down;

            up:
            Cliente qualquercoisa = Cliente.ConsultarPorId(int.Parse(txtId.Text));

            try
            {
                if (qualquercoisa.Nome == null)
                {
                    MessageBox.Show($"Erro! O usuário de ID {txtId.Text} não existe");
                    return;
                }

                btnBuscar.Text = "...";
                txtId.ReadOnly = true;
                txtCpf.ReadOnly = true;
                btnAlterar.Enabled = true;



                txtNome.Text = qualquercoisa.Nome.ToString();
                txtCpf.Text = qualquercoisa.Cpf.ToString();
                txtEmail.Text = qualquercoisa.Email.ToString();
                dtpDatacad.Text = qualquercoisa.DataCad.ToString();
                chkAtivo.Checked = qualquercoisa.Ativo;

                //btnAlterar.Enabled = false;

            }
            catch { }

            return;

        down:

            if (txtId.Text != "")
            {
                MessageBox.Show("Erro, Limpe a tela primeiro!");
                return;
            }

            btnBuscar.Text = "Buscar";
            txtId.Focus();

            txtId.ReadOnly = false;
            txtCpf.ReadOnly = false;
            btnAlterar.Enabled = false;

            return;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();

            try
            {
                cliente.Alterar(int.Parse(txtId.Text), txtNome.Text, txtEmail.Text);
                MessageBox.Show("Cliente alterado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Falha na alteração!");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCpf.ReadOnly = false;
            txtId.ReadOnly = true;
            btnBuscar.Text = "...";
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            btnAlterar.Enabled = false;
            dtpDatacad.Value = DateTime.Now;
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (chkManualMode.Checked == false)
                try
                {
                    DBCep dbcep = new DBCep(txtCep.Text);

                    txtLogradouro.Text = dbcep.TIPOMAISLOGRADOURO;
                    txtBairro.Text = dbcep.BAIRRO;
                    txtCidade.Text = dbcep.CIDADE;
                    txtUF.Text = dbcep.UF;
                    cmbEstado.SelectedItem = dbcep.ESTADO;
                }
                catch { }

            else
                return;
        }

        private void chkManualMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManualMode.Checked == true)
            {
                cmbEstado.DropDownStyle = ComboBoxStyle.DropDown;
                cmbEstado.Enabled = true;

                txtLogradouro.ReadOnly = false;
                txtBairro.ReadOnly = false;
                txtCidade.ReadOnly = false;
                txtUF.ReadOnly = false;
            }

            else
            {
                cmbEstado.DropDownStyle = ComboBoxStyle.Simple;
                cmbEstado.Enabled = false;

                txtLogradouro.ReadOnly = true;
                txtBairro.ReadOnly = true;
                txtCidade.ReadOnly = true;
                txtUF.ReadOnly = true;
            }
        }

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
