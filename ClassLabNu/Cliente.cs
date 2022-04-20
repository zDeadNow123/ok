﻿using System;
using System.Collections.Generic;
using System.Data;
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
            Nome = nome;
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
        public void Inserir() 
        {
            /*
            //                 BLOCO 1                    //
            //============================================//
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values('"+Nome+"', '"+Cpf+"', '"+Email+"', default, default)";
            cmd.ExecuteNonQuery();
            //--------------------------------------------//

            //                 BLOCO 2                    //
            //============================================//
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            //--------------------------------------------//

            //                 BLOCO 3                    //
            //============================================//
            cmd.Connection.Close();
            // <C><O><M><E><N><T><Á><R><I><O><><><><><><><><> insert clientes (nome, cpf, email, datacad, ativo) values('nomedapessoa', '2132121332', 'asdsada@sadsa.com', default, default);
            //--------------------------------------------//
            */


            //                 BLOCO 1-1
            //============================================//
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_cpf", Cpf);
            cmd.Parameters.AddWithValue("_email", Email);

            Id = Convert.ToInt32(cmd.ExecuteScalar());
            //--------------------------------------------//

            cmd.Connection.Close();
        }
        public bool Alterar(int _id, string _nome = default, string _email = default)
        {

            try 
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_cliente_alterar";
                cmd.Parameters.AddWithValue("_id", _id);
                cmd.Parameters.AddWithValue("_nome", _nome);
                cmd.Parameters.AddWithValue("_email", _email);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch
            {
                return false;
        
            }

        }

        public static Cliente ConsultarPorId(int _id) 
        { 
            Cliente cliente = new Cliente();
            
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where idCli = " + _id;
            
            var dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cliente.Id = Convert.ToInt32(dr["idCli"]);
                cliente.Nome = dr["nome"].ToString();
                cliente.Cpf = dr.GetString("cpf");
                cliente.Email = dr.GetString("email");
                cliente.DataCad = dr.GetDateTime("datacad");
                cliente.Ativo = dr.GetBoolean("ativo");
        }

            return cliente;
        }
        public static Cliente ConsultarPorCpf(string _cpf)
        {
            Cliente cliente = new Cliente();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "select * from clientes where cpf = " + _cpf;
            
            var dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cliente.Cpf = dr.GetString("cpf");
        }
            return cliente;
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> clientes = new List<Cliente>();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from clientes";
            //cmd.CommandText = "select * from clientes order by 2"; // Ordenar a partir da coluna 2
            cmd.CommandText = "select * from clientes where ativo = 1";
            var dr = cmd.ExecuteReader();

            while (dr.Read()) {

                clientes.Add(
                    new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5)
                    )
                );
                
            } // END WHILE

            return clientes;
        }

        public void Desativar(int _id) {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set ativo = 0 where idCli = " + _id;
            cmd.ExecuteReader();
            cmd.Connection.Close();
        }

    }
}
