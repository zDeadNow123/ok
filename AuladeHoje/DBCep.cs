using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLabNu;
using System.Data;

namespace AuladeHoje
{
    public class DBCep
    {
            private string uf;
            private string bairro;
            private string cidade;
            private string estado;
            private string logradouro;
            private string tipologradouro;

            public string UF { get { return uf; } set { uf = value; } }
            public string BAIRRO { get { return bairro; } set { bairro = value; } }
            public string CIDADE { get { return cidade; } set { cidade = value; } }
            public string ESTADO { get { return estado; } set { estado = value; } }
            public string LOGRADOURO { get { return logradouro; } set { logradouro = value; } }
            public string TIPOLOGRADOURO { get { return tipologradouro; } set { tipologradouro = value; } }
            public string TIPOMAISLOGRADOURO { get { return $"{TIPOLOGRADOURO} {LOGRADOURO}"; } }

        public DBCep(string cep) {

            var cmd = Banco.Abrir("127.0.0.1", "ceps", "root", "123", "3306");

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select UF, CEPS, CEPE from identcep";
            var reader = cmd.ExecuteReader();

            while (reader.Read()) {

                if (int.Parse(cep) >= int.Parse(reader.GetString(1)) && int.Parse(cep) <= int.Parse(reader.GetString(2)))
                {
                    uf = reader.GetString(0).ToLower();
                    break;
                }
            }

            reader.Close();

            if (uf == null) {
                cmd.Connection.Close();
                return;
            }

            cmd.CommandText = $"select * from {uf} where cep = {'"'}{String.Format("{0:0####-###}", int.Parse(cep))}{'"'}";

            reader = cmd.ExecuteReader();
            reader.Read();

            cidade = reader.GetString(1);
            estado = reader.GetString(6);
            logradouro = reader.GetString(2);
            bairro = reader.GetString(3);
            tipologradouro = reader.GetString(5);
            uf = uf.ToUpper();

            reader.Close();

            cmd.Connection.Close();
        }
    }
}
