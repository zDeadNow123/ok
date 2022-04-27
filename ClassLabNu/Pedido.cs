﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class Pedido
    {
        // idped	data	status_ped	desconto	idcli_ped	iduser_ped
        // Atibutos 

        // Propriedades
        public int Id { get ; set; }
        public DateTime DataPed { get; set;}
        public string Status { get; set;}
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItemPedido> Itens { get; set; }

        // construtores
        public Pedido() { }

        public Pedido(string status, double desconto, Cliente cliente, Usuario usuario) {
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
        }

        public Pedido(DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens) 
        {
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }

        public Pedido(int id, DateTime dataPed, string status, double desconto, Cliente cliente, Usuario usuario, List<ItemPedido> itens)
        {
            Id = id;
            DataPed = dataPed;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            Itens = itens;
        }
        // Métodos da classe - Operações/Açoes/Funções
        public void Inserir() {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_pedido_inserir";
            cmd.Parameters.AddWithValue("_desconto", Desconto);
            cmd.Parameters.AddWithValue("_idCli_ped", Cliente);
            cmd.Parameters.AddWithValue("_idUser_ped", Usuario);

            cmd.ExecuteScalar();

            cmd.Connection.Close();
        }
        public bool Alterar(Pedido pedido)
        { 
            return false;
        }
        public static Pedido ConsultarPorId(int _id)
        { 
            Pedido pedido = new Pedido(); 
            // graça...conecta ao banco e realiza a consulta pelo id do pedido
            return pedido;
        }
        public static List<Pedido> ConsultarPorClienteId(int _id)
        {
            List<Pedido> pedidos = new List<Pedido>();
            // graça...conecta ao banco e realiza a consulta pelo id do cliente
            return pedidos;
        }
    }
}
