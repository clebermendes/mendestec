using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Model;

namespace DAO
{
    public class UsuarioDAO
    {
        public static int ChecarLogin(string login, string senha)
        {

            int retorno = 0;
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT login, senha FROM Usuario ");
            SQL.Append(@"WHERE login = '@LOGIN' and senha = '@SENHA'");
            
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {

                    connection.Open();

                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.Add(new SqlParameter("@LOGIN", login));
                    command.Parameters.Add(new SqlParameter("@SENHA", senha));
                    retorno = command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return retorno;
        }

        public static bool InsertUser(UsuarioDTO usuario)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"INSERT INTO Usuario (codigo,nome,login,cpf,senha");
                SQL.Append(@"VALUES (NEXT VALUE FOR dbo.Sequence_User,@NOME,@LOGIN,@CPF,@SENHA)");

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@NOME", usuario.nomeCompleto);
                    command.Parameters.AddWithValue("@LOGIN", usuario.login);
                    command.Parameters.AddWithValue("@CPF", usuario.cpf);
                    command.Parameters.AddWithValue("@SENHA", usuario.senha);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception erro)
            {
                throw erro;
            }

            return true;
        }

        public static List<UsuarioDTO> GetAllUsers()
        {
            List<UsuarioDTO> retorno = new List<UsuarioDTO>();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT nome,login, cpf FROM Usuario");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);


                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            UsuarioDTO usuario= new UsuarioDTO();
                            usuario.nomeCompleto = (Convert.ToString(reader["nome"]));
                            usuario.login = Convert.ToString(reader["login"]);
                            usuario.cpf = (Convert.ToString(reader["cpf"]));
                            retorno.Add(usuario);
                        }
                    }
                }

            }
            catch (Exception Erro)
            {
                throw Erro;
            }
            return retorno;
        }

    }

}
