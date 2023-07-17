using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;

namespace PJ_IN
{
    public class Conexão
    {
        public SqlConnection conn = new SqlConnection("Persist Security Info = False; User ID = aline; Initial Catalog = db_aline; Data Source = dbaulabanco.ce9eq7mml3ie.sa - east - 1.rds.amazonaws.com");

        public void conectar()
        {
            conn.Open();
        }

        public void desconetar()
        {
            conn.Close();
        }
    }
}
