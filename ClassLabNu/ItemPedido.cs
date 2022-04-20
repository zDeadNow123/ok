using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class ItemPedido
    {
        // idped_ip	idprod_ip	valor	quantidade	desconto
        // Atributos
        private int X;
        private int idPed_ip, idProd_ip;
        private Produto produto;
        private double valor;
        private double quantidade;
        private double desconto;
        
        // propriedades
        public int IdPed_ip { get { return idPed_ip; } set { idPed_ip = value; } }
        public int IdProd_ip { get { return idProd_ip; } set { idProd_ip = value; } }
        public Produto Produto { get { return produto; } set { produto = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Quantidade { get { return quantidade; }set { quantidade = value; } }
        public double Desconto { get { return desconto; }set { desconto = value; } }

        // construtores
        public ItemPedido() { }

        public ItemPedido(Produto produto, double valor, double quantidade, double desconto)
        {
            this.produto = produto;
            this.valor = valor;
            this.quantidade = quantidade;
            this.desconto = desconto;
        }

        // métodos da classe - Ações da classe
        public void Inserir() {

            //                 BLOCO 1-1
            //============================================//
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_itempedido_inserir";
            cmd.Parameters.AddWithValue("_idPed_ip", IdPed_ip);
            cmd.Parameters.AddWithValue("_idProd_ip", IdProd_ip);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_quantidade", Quantidade);
            cmd.Parameters.AddWithValue("_desconto", Desconto);

            X = Convert.ToInt32(cmd.ExecuteScalar());
            //--------------------------------------------//

            cmd.Connection.Close();
        }
        public bool Alterar(int _idPed, int _idProd, double _valor, double _quantidade, double _desconto) {

            try {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_itempedido_alterar";
                cmd.Parameters.AddWithValue("_idPed_ip", _idPed);
                cmd.Parameters.AddWithValue("_idProd_ip", _idProd);
                cmd.Parameters.AddWithValue("_valor", _valor);
                cmd.Parameters.AddWithValue("_quantidade", _quantidade);
                cmd.Parameters.AddWithValue("_desconto", _desconto);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch {
                return false;

            }
        }

    }
}
