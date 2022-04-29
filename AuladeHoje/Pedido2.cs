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

namespace AuladeHoje
{
    public partial class Pedido2 : Form
    {
        public Pedido2()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Usuario usuario = new Usuario();

            Pedido pedido = new Pedido(lblStatus.Text, Double.Parse(txtDesconto.Text), cliente, usuario);
            pedido.Inserir();

            
            if(pedido.Status == )
            lblStatus.ForeColor = Color.Red;
            lblStatus.ForeColor = Color.White;
        }

    }
}
