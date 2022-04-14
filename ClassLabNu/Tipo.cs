using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu {
    public class Tipo {


        private int id;
        string nome, sigla;


        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Sigla { get { return sigla; } set { sigla = value; } }


        public Tipo() {
        }

        public Tipo(string nome, string sigla) {
            Nome = nome;
            Sigla = sigla;
        }

        public Tipo(int id, string nome, string sigla) {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        public void Inserir() {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_tipo_inserir";
            cmd.Parameters.AddWithValue("_nome", Nome);
            cmd.Parameters.AddWithValue("_sigla", Sigla);

            id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        public static List<Tipo> ListarTodos() {
            List<Tipo> tipos = new List<Tipo>();

            // Abrir o banco de dados
            var cmd = Banco.Abrir();


            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tipos";
            var dr = cmd.ExecuteReader();

            while (dr.Read()) {

                tipos.Add(
                    new Tipo(
                        dr.GetInt32(0), // ID
                        dr.GetString(1), // NOME
                        dr.GetString(2) // SIGLA
                    )
                );

            } // END WHILE

            return tipos;
        }


    }
}
