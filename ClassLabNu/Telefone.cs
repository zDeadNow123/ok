using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu {
    public class Telefone {

        private int idtel;
        private string ddd;
        private string numero;
        private string tipo;
        private int idcli_tel;

        private List<string> listadetipo = new List<string>();
        private List<string> listadeddd = new List<string>();
        private List<string> listadenumero = new List<string>();

        private List<string> listadetiposporindex = new List<string>();

        public int IdTel { get { return idtel; } }
        public string DDD { get { return ddd; } set { ddd = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string Tipo { get { return tipo; } set { tipo = value;} }
        public int Idcli_Tel { get { return idcli_tel; } }
        public List<string> Listadetipo { get { return listadetipo; } set { listadetipo = value; } }
        public List<string> Listadeddd { get { return listadeddd; } set { listadeddd = value; } }
        public List <string> Listadenumero { get { return listadenumero; } set { listadenumero = value; } }
        public List<string> Listadetiposporindex { get { return listadetiposporindex; } set { listadetiposporindex = value; } }

        public Telefone() {
        }

        public Telefone(string _ddd, string _numero, string _tipo, int _idcli_tel)
        {
            this.ddd = _ddd;
            this.numero = _numero;
            this.tipo = _tipo;
            this.idcli_tel = _idcli_tel;
        }

        public Telefone(int _idtel, string _ddd, string _numero, string _tipo, int _idcli_tel)
        {
            this.idtel = _idtel;
            this.numero = _numero;
            this.tipo = _tipo;
            this.idcli_tel = _idcli_tel;
        }

        public void Inserir() {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_telefones_inserir";
            cmd.Parameters.AddWithValue("_ddd", DDD);
            cmd.Parameters.AddWithValue("_numero", Numero);
            cmd.Parameters.AddWithValue("_tipo", Tipo);
            cmd.Parameters.AddWithValue("_idCli_tel", Idcli_Tel);

            idtel = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

        public bool Alterar(string _ddd, string _numero, string _tipo, int _idcli_tel) {

            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_telefones_alterar";
                cmd.Parameters.AddWithValue("_ddd", _ddd);
                cmd.Parameters.AddWithValue("_numero", _numero);
                cmd.Parameters.AddWithValue("_tipo", _tipo);
                cmd.Parameters.AddWithValue("_idCli_tel", _idcli_tel);
                idcli_tel = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Connection.Close();

                return true;
            }
            catch
            {
                return false;

            }
        }

        public static void Remover(string idCli, string ddd, string numeroTel) {

            try
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"delete from telefones where idCli_tel = {idCli} and ddd = {ddd} and numero = {numeroTel}";
                cmd.ExecuteNonQuery();

                cmd.Connection.Close();
            }
            catch {}

        }

        public static Telefone ConsultarPorId(int _idCli_tel)
        {
            Telefone telefone = new Telefone();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where idCli_tel = {_idCli_tel}";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                telefone.idtel = dr.GetInt32(0);
                telefone.ddd = dr.GetString(1);
                telefone.listadeddd.Add(telefone.ddd);
                telefone.numero = dr.GetString(2);
                telefone.listadenumero.Add(telefone.numero);
                telefone.tipo = dr.GetString(3);
                telefone.listadetipo.Add(telefone.tipo);
                telefone.idcli_tel = dr.GetInt32(4);
                telefone.listadetiposporindex.Add(telefone.tipo);
            }

            return telefone;

        }

        public static Telefone ConsultarPoridnddd(int _id, int _numero, int _ddd)
        {
            Telefone telefone = new Telefone();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from telefones where idCli_tel = {_id} and ddd = {_ddd} and numero = {_numero}";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                telefone.idtel = dr.GetInt32(0);
                telefone.ddd = dr.GetString(1);
                telefone.listadeddd.Add(telefone.ddd);
                telefone.numero = dr.GetString(2);
                telefone.listadenumero.Add(telefone.numero);
                telefone.tipo = dr.GetString(3);
                telefone.listadetipo.Add(telefone.tipo);
                telefone.idcli_tel = dr.GetInt32(4);
                telefone.listadetiposporindex.Add(telefone.tipo);
            }

            cmd.Connection.Close();
            return telefone;

        }

        public static List<Telefone> Listar() {
            List<Telefone> telefones = new List<Telefone>();

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from telefones";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                telefones.Add(
                    new Telefone(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetInt32(4)
                    )
                );

            } // END WHILE

            return telefones;
        }

    }
}
