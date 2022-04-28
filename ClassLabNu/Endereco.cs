using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu {
    public class Endereco {

        private int idend;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string tipo;
        private int idcli_end;

        public int Idend { get { return idend; } set { idend = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public string Numero { get { return numero; } set { numero = value;} }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Uf { get { return uf; } set { uf = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public int Idcli_end { get { return idcli_end; } set { idcli_end = value; } }

        public Endereco() {
        }

        public Endereco(int idend, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, int idcli_end) {
            this.idend = idend;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.idcli_end = idcli_end;
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, int idcli_end) {
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.idcli_end = idcli_end;
        }

        public void Inserir() {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_enderecos_inserir";
            cmd.Parameters.AddWithValue("_cep", Cep);
            cmd.Parameters.AddWithValue("_logradouro", Logradouro);
            cmd.Parameters.AddWithValue("_numero", Numero);
            cmd.Parameters.AddWithValue("_complemento", Complemento);
            cmd.Parameters.AddWithValue("_bairro", Bairro);
            cmd.Parameters.AddWithValue("_cidade", Cidade);
            cmd.Parameters.AddWithValue("_estado", Estado);
            cmd.Parameters.AddWithValue("_uf", Uf);
            cmd.Parameters.AddWithValue("_idCli_end", idcli_end);

            Idend = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        public bool Alterar(int IDEND, string CEP, string LOGRADOURO, string NUMERO, string COMPLEMENTO, string BAIRRO, string CIDADE, string ESTADO, string UF, int IDCLI_END) {

            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_enderecos_alterar";
                cmd.Parameters.AddWithValue("_idEnd", IDEND);
                cmd.Parameters.AddWithValue("_cep", CEP);
                cmd.Parameters.AddWithValue("_logradouro", LOGRADOURO);
                cmd.Parameters.AddWithValue("_numero", NUMERO);
                cmd.Parameters.AddWithValue("_complemento", COMPLEMENTO);
                cmd.Parameters.AddWithValue("_bairro", BAIRRO);
                cmd.Parameters.AddWithValue("_cidade", CIDADE);
                cmd.Parameters.AddWithValue("_estado", ESTADO);
                cmd.Parameters.AddWithValue("_uf", UF);
                cmd.Parameters.AddWithValue("_idCli_end", IDCLI_END);
                idend = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Connection.Close();
                return true;
            }
            catch
            {
                return false;

            }
        }

        public static Endereco ConsultarPorId(int _idCli_end)
        {
            Endereco endereco = new Endereco();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from enderecos where idCli_end = " + _idCli_end;

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                endereco.Idend = dr.GetInt32(0);
                endereco.Cep = dr.GetString(1);
                endereco.Logradouro = dr.GetString(2);
                endereco.Numero = dr.GetString(3);
                endereco.Complemento = dr.GetString(4);
                endereco.Bairro = dr.GetString(5);
                endereco.Cidade = dr.GetString(6);
                endereco.Estado = dr.GetString(7);
                endereco.Uf = dr.GetString(8);
                endereco.Idcli_end = dr.GetInt32(9);
            }

            return endereco;
        }

        public static List<Endereco> Listar()
        {
            List<Endereco> enderecos = new List<Endereco>();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from enderecos";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                enderecos.Add(
                    new Endereco(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetString(5),
                        dr.GetString(6),
                        dr.GetString(7),
                        dr.GetString(8),
                        dr.GetInt32(9)
                    )
                );

            } // END WHILE

            return enderecos;
        }

    }
}