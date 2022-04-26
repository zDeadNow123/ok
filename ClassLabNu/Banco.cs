using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClassLabNu {
    public static class Banco {

        public static string StrConexao { get; set; }

        // método Abrir conexão

        public static MySqlCommand Abrir() {
            MySqlCommand cmd = new MySqlCommand();
            StrConexao = @"server=127.0.0.1;database=comercialdb0191;user id=root;password=123;port=3306";
            MySqlConnection cn = new MySqlConnection(StrConexao);

            try {

                cn.Open();
            }
            catch {}

            cmd.Connection = cn;

            return cmd;
        }

    }
}
