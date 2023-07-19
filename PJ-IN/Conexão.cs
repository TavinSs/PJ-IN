using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace PJ_IN
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Persist Security Info = False; User ID = aline; Initial Catalog = db_aline; Data Source = dbaulabanco.ce9eq7mml3ie.sa - east - 1.rds.amazonaws.com");

        public void Conectar()
        {
            conn.Open();
        }

        public void Desconetar()
        {
            conn.Close();
        }

        public bool BuscarUsuario(string usuario, string senha)
        {
            string sql = $"select * from Usuario where Login = '{usuario}' and Senha = '{senha}' ";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return false;
        }   
    }
}
