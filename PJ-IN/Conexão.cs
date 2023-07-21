﻿using System.Data.SqlClient;

namespace PJ_IN
{
    public class Conexao
    {
        private SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

        public SqlConnection conn;

        public Conexao()
        {
            builder.DataSource = "dbaulabanco.ce9eq7mml3ie.sa-east-1.rds.amazonaws.com";
            builder.InitialCatalog = "db_aline";
            builder.UserID = "aline";
            builder.Password = "aline44!";
            builder.IntegratedSecurity = false;

            conn = new SqlConnection(builder.ConnectionString); 
        }

        public void Conectar()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {             
                conn.Open();
            }
        }

        public void Desconectar()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public bool BuscarUsuario(string usuario, string senha)
        {
            Conectar();

            string sql = "SELECT COUNT(*) FROM LoginUsuario WHERE Usuario = @Usuario AND Senha = @Senha";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Senha", senha);

            int count = (int)comando.ExecuteScalar();
            Desconectar();

            return count > 0;
        }

        public bool EhAdm(string usuario)
        {
            Conectar();

            string sql = "SELECT EhAdm FROM LoginUsuario WHERE Usuario = @Usuario";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.Parameters.AddWithValue("@Usuario", usuario);

            bool EhAdm = (bool)comando.ExecuteScalar();
            Desconectar();

            return EhAdm;
        }

        public List<Socio> DadosUsuario()
        {
            string sql = "SELECT * FROM Socio";
            SqlCommand comando = new SqlCommand(sql, conn);
            List<Socio> socios = new();
            using (var reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nomeDb = reader.GetString(reader.GetOrdinal("Nome"));
                    var dataNascimentoDb = reader.GetDateTime(reader.GetOrdinal("DataNascimento"));
                    var cpfDb = reader.GetString(reader.GetOrdinal("Cpf"));
                    var telefoneDb = reader.GetString(reader.GetOrdinal("Telefone"));
                    var emailDb = reader.GetString(reader.GetOrdinal("Email"));
                    var numeroDb = reader.GetString(reader.GetOrdinal("Numero"));
                    var complementoDb = reader.GetString(reader.GetOrdinal("Complemento"));
                    var referenciaDb = reader.GetString(reader.GetOrdinal("Referencia"));

                    socios.Add(new Socio()
                    {
                        Nome = nomeDb,
                        DataNascimento = dataNascimentoDb,
                        Cpf = cpfDb,
                        Telefone = telefoneDb,
                        Email = emailDb,                        
                        Numero = numeroDb,
                        Complemento = complementoDb,
                        Referencia = referenciaDb

                    });
                }
                return socios;
            }
        }
    }
}
