using MySql.Data.MySqlClient;
using System.Data;

namespace diamond_story_grupo3
{
    class Conexao
    {   

        private MySqlConnection conexao;

        public void conectarBD()
        {
            conexao = new MySqlConnection("persist security info = false;" +
                                          "server=localhost;" +
                                          "database=sistema_2c2_grupo3;" +
                                          "uid=root;" +
                                          "pwd=;SslMode=none ");
            conexao.Open();
        }

        public void AlterarTabelas(string sql)
        {
            conectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();

        }
        public DataTable ConsultarTabelas(string sql)
        {
            conectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}
