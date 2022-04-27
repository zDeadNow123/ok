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
            private string _UF;
            private string bairro;
            private string cidade;
            private string estado;
            private string logradouro;
            private string tipologradouro;
            private string tipomaislogradouro;

            public string UF { get { return _UF; } set { _UF = value; } }
            public string BAIRRO { get { return bairro; } set { bairro = value; } }
            public string CIDADE { get { return cidade; } set { cidade = value; } }
            public string ESTADO { get { return estado; } set { estado = value; } }
            public string LOGRADOURO { get { return logradouro; } set { logradouro = value; } }
            public string TIPOLOGRADOURO { get { return tipologradouro; } set { tipologradouro = value; } }
            public string TIPOMAISLOGRADOURO { get { return $"{TIPOLOGRADOURO} {LOGRADOURO}"; } set { tipomaislogradouro = value; } }

        public DBCep(string cep) {

            if (int.Parse(cep) >= 69900000 && int.Parse(cep) <= 69999999) UF = "AC".ToLower();
            else if (int.Parse(cep) >= 57000000 && int.Parse(cep) <= 57999999) UF = "AL".ToLower();
            else if (int.Parse(cep) >= 69000000 && int.Parse(cep) <= 69299999) UF = "AM".ToLower();
            else if (int.Parse(cep) >= 69400000 && int.Parse(cep) <= 69899999) UF = "AM".ToLower();
            else if (int.Parse(cep) >= 68900000 && int.Parse(cep) <= 68999999) UF = "AP".ToLower();
            else if (int.Parse(cep) >= 40000000 && int.Parse(cep) <= 48999999) UF = "BA".ToLower();
            else if (int.Parse(cep) >= 60000000 && int.Parse(cep) <= 63999999) UF = "CE".ToLower();
            else if (int.Parse(cep) >= 60000000 && int.Parse(cep) <= 72799999) UF = "DF".ToLower();
            else if (int.Parse(cep) >= 73000000 && int.Parse(cep) <= 73699999) UF = "DF".ToLower();
            else if (int.Parse(cep) >= 29000000 && int.Parse(cep) <= 29999999) UF = "ES".ToLower();
            else if (int.Parse(cep) >= 72800000 && int.Parse(cep) <= 72999999) UF = "GO".ToLower();
            else if (int.Parse(cep) >= 73700000 && int.Parse(cep) <= 76799999) UF = "GO".ToLower();
            else if (int.Parse(cep) >= 65000000 && int.Parse(cep) <= 65999999) UF = "MA".ToLower();
            else if (int.Parse(cep) >= 30000000 && int.Parse(cep) <= 39999999) UF = "MG".ToLower();
            else if (int.Parse(cep) >= 79000000 && int.Parse(cep) <= 79999999) UF = "MS".ToLower();
            else if (int.Parse(cep) >= 58000000 && int.Parse(cep) <= 78899999) UF = "MT".ToLower();
            else if (int.Parse(cep) >= 66000000 && int.Parse(cep) <= 68899999) UF = "PA".ToLower();
            else if (int.Parse(cep) >= 58000000 && int.Parse(cep) <= 58999999) UF = "PB".ToLower();
            else if (int.Parse(cep) >= 50000000 && int.Parse(cep) <= 56999999) UF = "PE".ToLower();
            else if (int.Parse(cep) >= 64000000 && int.Parse(cep) <= 64999999) UF = "PI".ToLower();
            else if (int.Parse(cep) >= 80000000 && int.Parse(cep) <= 87999999) UF = "PR".ToLower();
            else if (int.Parse(cep) >= 20000000 && int.Parse(cep) <= 28999999) UF = "RJ".ToLower();
            else if (int.Parse(cep) >= 59000000 && int.Parse(cep) <= 59999999) UF = "RN".ToLower();
            else if (int.Parse(cep) >= 76800000 && int.Parse(cep) <= 76999999) UF = "RO".ToLower();
            else if (int.Parse(cep) >= 69300000 && int.Parse(cep) <= 69399999) UF = "RR".ToLower();
            else if (int.Parse(cep) >= 90000000 && int.Parse(cep) <= 99999999) UF = "RS".ToLower();
            else if (int.Parse(cep) >= 88000000 && int.Parse(cep) <= 89999999) UF = "SC".ToLower();
            else if (int.Parse(cep) >= 49000000 && int.Parse(cep) <= 49999999) UF = "SE".ToLower();
            else if (int.Parse(cep) >= 01000000 && int.Parse(cep) <= 19999999) UF = "SP".ToLower();
            else if (int.Parse(cep) >= 77000000 && int.Parse(cep) <= 77999999) UF = "TO".ToLower();
            else return;

            var cmd = Banco.Abrir("127.0.0.1", "ceps", "root", "123", "3306");

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = $"select * from {_UF} where cep = {'"'}{String.Format("{0:0####-###}", int.Parse(cep))}{'"'}";

            var dr = cmd.ExecuteReader();
            dr.Read();

            cidade = dr.GetString(1);
            estado = dr.GetString(6);
            logradouro = dr.GetString(2);
            bairro = dr.GetString(3);
            tipologradouro = dr.GetString(5);
            _UF = _UF.ToUpper();

            cmd.Connection.Close();
        }
    }
}
