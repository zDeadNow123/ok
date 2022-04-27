using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu {

    // Documentação de classes de projeto. - XML Docs 
    public class Usuario
    {

        public struct socorro {

            private int id;
            private string nome, email, senha, nivel;
            private bool ativo;

            public int Id { get { return id; } }
            public string Nome { get { return nome; } set { nome = value; } }
            public string Email { get { return email; } }
            public string Password { get { return senha; } }
            public string Nivel { get { return nivel; } }
            public bool Ativo { get { return ativo; } }

            public socorro(int id, string nome, string email, string senha, string nivel, bool ativo) {
                this.id = id;
                this.nome = nome;
                this.email = email;
                this.senha = senha;
                this.nivel = nivel;
                this.ativo = ativo;
            }

        }

        // atributos (campos)
        private int id;
        private string nome;
        private string email;
        private Nivel nivel;
        private string password;
        
        private bool ativo;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password
        {
            get
            {
                // restrições
                return password;
            }

        }
        public Nivel Nivel { get { return nivel; } }
        public bool Ativo { get { return ativo; } set { ativo = value; } }


        // métodos Construtores
        public Usuario()
        {

        }
        public Usuario(string nome, string email, Nivel nivel, string password)
        {
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel; 
            ativo = true;
        }

        public Usuario(int id, string nome, string email, string password, Nivel nivel, bool ativo)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.nivel = nivel;  
            this.ativo = ativo;
        }
        // métodos da classe
        public void Inserir() {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_email", Email);
            cmd.Parameters.AddWithValue("_senha", Password);
            cmd.Parameters.AddWithValue("_nivel", $"{Nivel.Nome}, {Nivel.Sigla}");

            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        public bool Alterar(int _id, string _nome, string _email, string _senha, string _idNv) {

            try {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_alterar";
                cmd.Parameters.AddWithValue("_id", _id);
                cmd.Parameters.AddWithValue("_nome", _nome);
                cmd.Parameters.AddWithValue("_email", _email);
                cmd.Parameters.AddWithValue("_senha", _senha);
                cmd.Parameters.AddWithValue("_idNv", _idNv);
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return true;
            }
            catch {
                return false;

            }
        }

        public static List<socorro> Listar() {
            List<socorro> usuarios = new List<socorro>();

            // Abrir o banco de dados
            var cmd = Banco.Abrir();


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios";
            var dr = cmd.ExecuteReader();

            while (dr.Read()) {

                
                usuarios.Add(
                    new socorro (
                        dr.GetInt32(0), // ID
                        dr.GetString(1), // NOME
                        dr.GetString(2), // EMAIL
                        dr.GetString(3), // SENHA
                        dr.GetString(4), // NIVEL
                        dr.GetBoolean(5) // ATIVO
                    )
                );
                

            } // END WHILE

            return usuarios;
        }

        public static bool EfetuarLogin(string email, string senha) 
        {
            // realiza validação e devolve verdadeiro ou falso
            return false;
        }
    }
}
