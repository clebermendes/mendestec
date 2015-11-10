using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace DAO
{
    public class TipoDAO
    {
        public static DataTable GetAllTipos()
        {
            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT codigo, nome_tipo FROM Tipo");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(retorno);
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }

            return retorno;
        }

        public static bool InsertType(TipoDTO tipo)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"INSERT INTO Tipo (codigo, nome_tipo)");
                SQL.Append(@"VALUES (NEXT VALUE FOR dbo.Sequence_Tipo,@DESCRICAO)");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@DESCRICAO", tipo.tipo_nome);
                    command.ExecuteNonQuery();
                    command.Dispose();

                }
                return true;
            }
            catch (Exception erro)
            {
                throw erro;
            }


        }

        public static double GetLastCodeType()
        {
            try
            {
                int codigo = 0;
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT MAX(codigo) as codigo FROM Tipo");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codigo = Convert.ToInt32(reader["codigo"]);
                        }
                    }

                }
                return codigo;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
