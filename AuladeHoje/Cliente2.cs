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
using ClosedXML.Excel;
using System.IO;

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
            if (txtNome.Text == "" || txtCpf.Text == "" || txtEmail.Text == "") { MessageBox.Show("Erro! Insira os dados do cliente primeiro"); return; }

            Cliente cliente = new Cliente(txtNome.Text, txtCpf.Text, txtEmail.Text);


            try
            {
                cliente.Inserir();
                MessageBox.Show($"O Cliente {cliente.Nome}\nfoi gravado com sucesso!");

                txtId_db.Text = cliente.Id.ToString();
                cmbTipo_principal.Enabled = true;

                // Gravar Endereço se estiver habilitado
                if (chkAddend.Checked == true)
                {
                    Endereco endereco = new Endereco(txtCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cmbEstado.SelectedItem.ToString(), txtUF.Text, int.Parse(txtId_db.Text));

                    try
                    {
                        endereco.Inserir();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException erro)
                    {
                        MessageBox.Show($"Erro! {erro.Message}");
                    }
                }

                // Gravar telefone se estiver habilitado
                if (chkAddTel.Checked == true)
                {
                    if (txtId_db.Text != "")
                        if (cmbTipo_principal.SelectedItem != null)

                            try
                            {
                                Telefone telefone = new Telefone(cmbDDD_tel.Text, cmbNumero_tel.Text, cmbTipo_principal.SelectedItem.ToString(), int.Parse(txtId_db.Text));
                                telefone.Inserir();

                                cmbDDD_tel.Items.Add(cmbDDD_tel.Text);
                                cmbDDD_tel.SelectedItem = cmbDDD_tel.Text;
                                cmbNumero_tel.Items.Add(cmbNumero_tel.Text);
                                cmbNumero_tel.SelectedItem = cmbNumero_tel.Text;
                            }
                            catch { }
                }
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
            Cliente cliente = Cliente.ConsultarPorId(int.Parse(txtId.Text));

            try
            {
                if (cliente.Nome == null)
                {
                    MessageBox.Show($"Erro! O usuário de ID {txtId.Text} não existe");
                    return;
                }

                txtId_db.Text = txtId.Text;
                Endereco endereco = Endereco.ConsultarPorId(int.Parse(txtId_db.Text));
                Telefone telefone = Telefone.ConsultarPorId(int.Parse(txtId_db.Text));

                btnBuscar.Text = "...";
                txtId.ReadOnly = true;
                txtCpf.ReadOnly = true;
                btnAlterar.Enabled = true;
                chkAtivo.Enabled = true;


                txtNome.Text = cliente.Nome;
                txtCpf.Text = cliente.Cpf;
                txtEmail.Text = cliente.Email;
                dtpDatacad.Text = cliente.DataCad.ToString();
                chkAtivo.Checked = cliente.Ativo;

                txtIdEnd_db.Text = endereco.Idend.ToString();
                txtCep.Text = endereco.Cep;
                txtLogradouro.Text = endereco.Logradouro;
                txtNumero.Text = endereco.Numero;
                txtComplemento.Text = endereco.Complemento;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                cmbEstado.SelectedItem = endereco.Estado;
                txtUF.Text = endereco.Uf;

                foreach (var items in telefone.Listadeddd) cmbDDD_tel.Items.Add(items);
                foreach (var items in telefone.Listadenumero) cmbNumero_tel.Items.Add(items);

                cmbDDD_tel.SelectedIndex = 0;
                cmbNumero_tel.SelectedIndex = 0;

                cmbTipo_principal.SelectedItem = Telefone.ConsultarPoridnddd(int.Parse(txtId.Text), int.Parse(cmbNumero_tel.SelectedItem.ToString()), int.Parse(cmbDDD_tel.SelectedItem.ToString())).Tipo;
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
            chkAtivo.Enabled = false;
            btnInserir.Enabled = false;

            return;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente();
            Endereco endereco = new Endereco();
            Telefone telefone = new Telefone();

            try
            {
                cliente.Alterar(int.Parse(txtId.Text), txtNome.Text, txtEmail.Text, chkAtivo.Checked);
                endereco.Alterar(int.Parse(txtIdEnd_db.Text), txtCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cmbEstado.SelectedItem.ToString(), txtUF.Text, int.Parse(txtId.Text));
                telefone.Alterar(cmbDDD_tel.Text, cmbNumero_tel.Text, cmbTipo_principal.SelectedItem.ToString(), int.Parse(txtId.Text));

                cmbDDD_tel.Items.Clear();
                cmbNumero_tel.Items.Clear();

                telefone = Telefone.ConsultarPorId(int.Parse(txtId.Text));

                foreach (var items in telefone.Listadeddd) cmbDDD_tel.Items.Add(items);
                foreach (var items in telefone.Listadenumero) cmbNumero_tel.Items.Add(items);

                cmbDDD_tel.SelectedIndex = 0;
                cmbNumero_tel.SelectedIndex = 0;

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
            txtId_db.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            chkAtivo.Enabled = false;
            chkAtivo.Checked = true;
            btnAlterar.Enabled = false;
            btnInserir.Enabled = true;
            dtpDatacad.Value = DateTime.Now;

            chkAddend.Checked = false;
            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cmbEstado.SelectedItem = null;
            txtUF.Clear();
            chkManualMode.Checked = false;

            chkAddTel.Checked = false;
            cmbTipo_principal.SelectedItem = null;
            cmbDDD_tel.SelectedItem = null;
            cmbNumero_tel.SelectedItem = null;
            cmbDDD_tel.ResetText();
            cmbNumero_tel.ResetText();
            cmbDDD_tel.Items.Clear();
            cmbNumero_tel.Items.Clear();

            dgvClientes.Rows.Clear();
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
            if (chkAddend.Checked != true) { chkManualMode.Checked = false; }

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

        private void btn_addTel_Click(object sender, EventArgs e)
        {
            if (cmbDDD_tel.SelectedItem != null || cmbNumero_tel.SelectedItem != null)
            {

                cmbDDD_tel.ResetText();
                cmbNumero_tel.ResetText();
                return;
            }

            if (cmbTipo_principal.SelectedItem != null)

                try
                {
                    Telefone telefone = new Telefone(cmbDDD_tel.Text, cmbNumero_tel.Text, cmbTipo_principal.SelectedItem.ToString(), int.Parse(txtId_db.Text));
                    telefone.Inserir();

                    cmbDDD_tel.Items.Add(cmbDDD_tel.Text);
                    cmbDDD_tel.SelectedItem = cmbDDD_tel.Text;
                    cmbNumero_tel.Items.Add(cmbNumero_tel.Text);
                    cmbNumero_tel.SelectedItem = cmbNumero_tel.Text;

                    MessageBox.Show("Telefone Inserido com Sucesso!");
                }
                catch
                {
                    MessageBox.Show("Falha ao Inserir Telefone!");
                }

            else MessageBox.Show("Erro! Selecione o Tipo primeiro");
        }

        private void chkAddTel_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAddTel.Checked == true)
            {
                cmbTipo_principal.Enabled = true;
                cmbDDD_tel.Enabled = true;
                cmbNumero_tel.Enabled = true;

                if (txtId.Text != "")
                {
                    btn_addTel.Enabled = true;
                    btn_removeTel.Enabled = true;
                }
            }
            else
            {
                cmbTipo_principal.Enabled = false;
                cmbDDD_tel.Enabled = false;
                cmbNumero_tel.Enabled = false;
                btn_addTel.Enabled = false;
                btn_removeTel.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtId_db.Text == "")
            {
                MessageBox.Show("Erro! Insira ou busque o usuário primeiro");
                return;
            }

            Endereco endereco = new Endereco(txtCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cmbEstado.SelectedItem.ToString(), txtUF.Text, int.Parse(txtId_db.Text));

            try
            {
                endereco.Inserir();
                MessageBox.Show($"O Endereco foi gravado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException erro)
            {
                MessageBox.Show($"Erro! {erro.Message}");
            }
        }

        private void btn_removeTel_Click(object sender, EventArgs e)
        {

            if (cmbDDD_tel.Text == "" || cmbNumero_tel.Text == "")
            {
                MessageBox.Show("Falha ao Remover Telefone! Não existe ou não foi selecionado");
                return;
            }

            try
            {
                Telefone telefone = Telefone.ConsultarPorId(int.Parse(txtId.Text));

                if (!telefone.Listadeddd.Contains(cmbDDD_tel.Text) && !telefone.Listadenumero.Contains(cmbNumero_tel.Text))
                {
                    MessageBox.Show("Falha ao Remover Telefone! Inválido");
                    return;
                }

                Telefone.Remover(txtId.Text, cmbDDD_tel.Text, cmbNumero_tel.Text);

                cmbTipo_principal.SelectedItem = null;

                cmbDDD_tel.Items.Remove(cmbDDD_tel.Text);
                cmbNumero_tel.Items.Remove(cmbNumero_tel.Text);

                cmbDDD_tel.SelectedItem = null;
                cmbNumero_tel.SelectedItem = null;

                cmbDDD_tel.ResetText();
                cmbNumero_tel.ResetText();

                if (cmbDDD_tel.Items.Count > 0) cmbDDD_tel.SelectedIndex = 0;
                if (cmbNumero_tel.Items.Count > 0) cmbNumero_tel.SelectedIndex = 0;

                MessageBox.Show("Telefone Removido com Sucesso!");
            }
            catch
            {
                MessageBox.Show("Falha ao Remover Telefone!");
            }
        }

        private void cmbDDD_tel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNumero_tel.SelectedItem != null)
            {
                if (cmbDDD_tel.Text != "") cmbNumero_tel.SelectedIndex = cmbDDD_tel.SelectedIndex;
                else return;

                try
                {
                    cmbTipo_principal.SelectedItem = Telefone.ConsultarPoridnddd(int.Parse(txtId.Text), int.Parse(cmbNumero_tel.Text), int.Parse(cmbDDD_tel.Text)).Tipo;
                }
                catch { }
            }
        }

        private void cmbNumero_tel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDDD_tel.SelectedItem != null)
            {

                if (cmbNumero_tel.Text != "") cmbDDD_tel.SelectedIndex = cmbNumero_tel.SelectedIndex;
                else return;

                try
                {
                    cmbTipo_principal.SelectedItem = Telefone.ConsultarPoridnddd(int.Parse(txtId.Text), int.Parse(cmbNumero_tel.Text), int.Parse(cmbDDD_tel.Text)).Tipo;
                }
                catch { }
            }

        }

        private void chkAddend_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAddend.Checked == true)
            {
                txtCep.ReadOnly = false;
                txtNumero.ReadOnly = false;
                txtComplemento.ReadOnly = false;
                btnGravar_end.Enabled = true;
            }
            else
            {

                if (chkManualMode.Checked == true) chkManualMode.Checked = false;

                txtCep.ReadOnly = true;
                txtNumero.ReadOnly = true;
                txtComplemento.ReadOnly = true;
                btnGravar_end.Enabled = false;
            }

            return;
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        private void cmbDDD_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        private void cmbNumero_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) { e.Handled = true; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var savedlg = dialogoSalvarArquivo;
            savedlg.Filter = "Excel (*.xlsx)|*.xlsx";

            if (txtId.Text == "") {
                MessageBox.Show("Erro! Consulte um usuário primeiro");
                return;
            }

            if (savedlg.ShowDialog() == DialogResult.OK) {

                XLWorkbook workbook = new XLWorkbook();
                IXLWorksheet worksheetClientes = workbook.Worksheets.Add("Clientes");


                worksheetClientes.Cell("A1").Value = "ID";
                worksheetClientes.Cell("A2").Value = txtId.Text;

                worksheetClientes.Cell("B1").Value = "NOME";
                worksheetClientes.Cell("B2").Value = txtNome.Text;

                worksheetClientes.Cell("C1").Value = "CPF";
                worksheetClientes.Cell("C2").Value = txtCpf.Text;

                worksheetClientes.Cell("D1").Value = "EMAIL";
                worksheetClientes.Cell("D2").Value = txtEmail.Text;

                // -----------------------------------------------------------------------

                worksheetClientes.Cell("F1").Value = "CEP";
                worksheetClientes.Cell("F2").Value = "'" + txtCep.Text;

                worksheetClientes.Cell("G1").Value = "LOGRADOURO";
                worksheetClientes.Cell("G2").Value = txtLogradouro.Text;

                worksheetClientes.Cell("H1").Value = "NUMERO";
                worksheetClientes.Cell("H2").Value = txtNumero.Text;

                worksheetClientes.Cell("I1").Value = "COMPLEMENTO";
                worksheetClientes.Cell("I2").Value = txtComplemento.Text;

                worksheetClientes.Cell("J1").Value = "BAIRRO";
                worksheetClientes.Cell("J2").Value = txtBairro.Text;

                worksheetClientes.Cell("K1").Value = "CIDADE";
                worksheetClientes.Cell("K2").Value = txtCidade.Text;

                worksheetClientes.Cell("L1").Value = "ESTADO";
                worksheetClientes.Cell("L2").Value = cmbEstado.Text;

                worksheetClientes.Cell("M1").Value = "UF";
                worksheetClientes.Cell("M2").Value = txtUF.Text;

                // -----------------------------------------------------------------------

                worksheetClientes.Cell("O1").Value = "TELEFONES";
                var b = 1;
                for (int i = 0; i < cmbDDD_tel.Items.Count; i++) {
                    worksheetClientes.Cell("O" + (b += 1)).Value = $"({cmbDDD_tel.Items[i].ToString()}) {cmbNumero_tel.Items[i].ToString()}";
                }

                worksheetClientes.Columns().AdjustToContents();


                Stream excelStream = File.Create(Path.GetFullPath($@"{Path.GetFullPath(savedlg.FileName)}"));
                workbook.SaveAs(excelStream);
                excelStream.Dispose();
            }

        }
    }
}
