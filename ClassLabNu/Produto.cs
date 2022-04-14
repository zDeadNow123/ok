using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class Produto
    {
        // atributos da classe
        private int id;
        private string descricao;
        private double unidade;
        private string codBar;
        private double valor;
        private double desconto;
        private bool descontinuado;

        // propriedades
        public int Id { get { return id; } set { id = value; } }
        public string Descricao { get { return descricao; } set { descricao = value; } }
        public double Unidade { get { return unidade; } set { unidade = value; } }
        public string CodBar { get { return codBar; } set { codBar = value; } }
        public double Valor { get { return valor; } set { valor = value; } }
        public double Desconto { get { return desconto; } set { desconto = value; } }
        public bool Descontinuado { get { return descontinuado; } set { descontinuado = value; } }









        // construtores
        public Produto()
        {
        }








        public Produto(string descricao, double unidade, string codBar, double valor, double desconto)
        {
            this.descricao = descricao;
            this.unidade = unidade;
            this.codBar = codBar;
            this.valor = valor;
            this.desconto = desconto;
        }









        public Produto(int id, string descricao, double unidade, string codBar, double valor, double desconto, bool descontinuado)
        {
            this.id = id;
            this.descricao = descricao;
            this.unidade = unidade;
            this.codBar = codBar;
            this.valor = valor;
            this.desconto = desconto;
            this.descontinuado = descontinuado;
        }
























































        // métodos da Classe
        public void Inserir() {

            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_inserir";
            cmd.Parameters.AddWithValue("_descricao", Descricao);
            cmd.Parameters.AddWithValue("_unidade", Unidade);
            cmd.Parameters.AddWithValue("_codbar", CodBar);
            cmd.Parameters.AddWithValue("_valor", Valor);
            cmd.Parameters.AddWithValue("_desconto", Desconto);

            id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Connection.Close();
        }

















































































        public Produto BuscarPorId(int _id)
        {
            Produto produto = new Produto();
            // conecta banco realiza consulta por Id do produto
            return produto;
        }




















        public Produto BuscarPorCodBar(string _codBar)
        {
            Produto produto = new Produto();
            // conecta banco e realiza consulta por código de barras do produtos
            return produto;
        }




















        public List<Produto> BuscarPorDescricao(string _descricao)
        {
            List<Produto> produtos = new List<Produto>();
            // conecta banco e realiza consulta por parte da descriação do produtos
            return produtos;
        }














        public static List<Produto> ListarTodos() {
            List<Produto> produtos = new List<Produto>();

            // Abrir o banco de dados
            var cmd = Banco.Abrir();

            
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from produtos";
            var dr = cmd.ExecuteReader();

            while (dr.Read()) {

                produtos.Add(
                    new Produto(
                        dr.GetInt32(0), // ID
                        dr.GetString(1), // DESCRICAO
                        dr.GetDouble(2), // UNIDADE
                        dr.GetString(3), // CODBAR
                        dr.GetDouble(4), // VALOR
                        dr.GetDouble(5), // DESCONTO
                        dr.GetBoolean(6) // DESCONTINUADO
                    )
                );

            } // END WHILE

            return produtos;
        }























        public bool Alterar()
        { 
            return true; 
        }
        
    }// fim da classe produto
}
