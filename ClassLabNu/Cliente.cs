﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabNu
{
    public class Cliente
    {
        // atributos /
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }   
        public string Cpf { get { return cpf; }set { cpf = value; }  }
        public string Email { get { return email; }set { email = value; } }
        public DateTime DataCad { get { return dataCad; }set { dataCad = value; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }

        // construtores
        public Cliente()
        {
        }

        public Cliente(string nome, string cpf, string email)
        {
            Nome = this.nome;
            Cpf = cpf;
            Email = email;
            // DataCad = DateTime.Now;
            // ativo = true;
        }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            DataCad = dataCad;
            Ativo = ativo;
        }

        // métodos da classe
        public void Inserir(Cliente cliente) 
        { 
            
        }
        public bool Alterar(Cliente cliente)
        {
            return true;
        }
        public static Cliente ConsultarPorId(int _id) 
        { 
            Cliente cliente = new Cliente();
            // cenas dos próximos episódios...
            return cliente;
        }
        public static Cliente ConsultarPorCpf(string _cpf)
        {
            Cliente cliente = new Cliente();
            // cenas dos próximos episódios...
            return cliente;
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();
            // cenas dos próximos episódios...
            return clientes;
        }

    }
}
