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
    public partial class Usuario2 : Form {
        public Usuario2() {
            InitializeComponent();
        }

        private void btnInserir_user_Click(object sender, EventArgs e) {

            Random random = new Random();

            Usuario usuario = new Usuario(
                txtNome_user.Text,
                txtEmail_user.Text,
                new Nivel(txtNivel_user.Text, "" + (char)random.Next('A', 'Z') + "" + (char)random.Next('A', 'Z')),
                txtSenha_user.Text
            );

            try {
                usuario.Inserir();
                txtId_user.Text = usuario.Id.ToString();
                MessageBox.Show($"O Usuario {usuario.Nome}\nfoi inserido com sucesso");

            }
            catch (MySql.Data.MySqlClient.MySqlException erro) {
                MessageBox.Show($"Plin plin plin, uma falha, foi detectada: {erro.Message}");
            }
        }

        private void btnRead_user_Click(object sender, EventArgs e) {

            foreach (var item in Usuario.Listar()) {
                listUser.Items.Add($"ID: {item.Id}, NOME: {item.Nome}, EMAIL: {item.Email}, SENHA: {item.Password}, NIVEL: {item.Nivel}, ATIVO: {item.Ativo}");
            }

        }
    }
}
