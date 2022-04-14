using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuladeHoje {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) {
            Produto2 produto = new Produto2();
            produto.Show();
        }

        private void tipoToolStripMenuItem_Click(object sender, EventArgs e) {
            Tipo2 tipo = new Tipo2();
            tipo.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e) {
            Usuario2 usuario = new Usuario2();
            usuario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e) {
            Cliente2 cliente = new Cliente2();
            cliente.Show();
        }
    }
}
