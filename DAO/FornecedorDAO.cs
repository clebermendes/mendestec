using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Model;

namespace DAO
{
    public class FornecedorDAO
    {
        public static DataTable GetAllFornecedores()
        {
            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT codigo, nomeFantasia FROM Fornecedor");

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

        public static double GetLastBarCode()
        {
            try
            {
                double codigo = 0;
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT MAX(codigo) as codigo FROM Fornecedor");


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
                            codigo = Convert.ToDouble(reader["codigo"]);
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

        public static FornecedorDTO GetFornecedorByCode(int codigo)
        {
            try
            {
                FornecedorDTO fornecedor = new FornecedorDTO();
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT f.codigo,f.nomeFantasia, f.cnpj, f.telefone, f.complemento, f.bairro, f.numero, f.cep, e.sigla, c.Nome FROM Fornecedor f ");
                SQL.Append(@"INNER JOIN Cidade c ON (f.cidade_id = c.CidadeId) ");
                SQL.Append(@"INNER JOIN Estado e ON (c.EstadoId = e.EstadoId) ");
                SQL.Append(@"WHERE f.codigo = @CODIGO ");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", codigo);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            fornecedor.codigo = Convert.ToInt32(reader["codigo"]);
                            fornecedor.nomeFantasia = (reader["nomeFantasia"]).ToString();
                            fornecedor.cnpj = reader["cnpj"].ToString();
                            fornecedor.telefone = reader["telefone"].ToString();
                            fornecedor.complemento = reader["complemento"].ToString();
                            fornecedor.bairro = reader["bairro"].ToString();
                            fornecedor.numero = reader["numero"].ToString();
                            fornecedor.cep = reader["cep"].ToString();
                            fornecedor.cidade.estado.sigla = reader["sigla"].ToString();
                            fornecedor.cidade.nome = reader["Nome"].ToString();

                        }
                    }

                }
                return fornecedor;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static bool InsertFornecedor(FornecedorDTO fornecedor)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"INSERT INTO Fornecedor (codigo,nome, nomeFantasia, cnpj, telefone, email, complemento, bairro,numero, cep, cidade_id, estado_id)");
                SQL.Append(@"VALUES (NEXT VALUE FOR dbo.Sequence_Fornecedor, @NOME,@NOMEFANTASIA,@CNPJ,@TELEFONE,@EMAIL,@COMPLEMENTO,@BAIRRO,@NUMERO, @CEP, @CIDADE_ID, @ESTADO_ID)");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@NOME", fornecedor.nome);
                    command.Parameters.AddWithValue("@NOMEFANTASIA", fornecedor.nomeFantasia);
                    command.Parameters.AddWithValue("@CNPJ", fornecedor.cnpj);
                    command.Parameters.AddWithValue("@TELEFONE", fornecedor.telefone);
                    command.Parameters.AddWithValue("@EMAIL", fornecedor.email);
                    command.Parameters.AddWithValue("@COMPLEMENTO", fornecedor.complemento);
                    command.Parameters.AddWithValue("@BAIRRO", fornecedor.bairro);
                    command.Parameters.AddWithValue("@NUMERO", fornecedor.numero);
                    command.Parameters.AddWithValue("@CEP", fornecedor.cep);
                    command.Parameters.AddWithValue("@CIDADE_ID", fornecedor.cidade_id);
                    command.Parameters.AddWithValue("@ESTADO_ID", fornecedor.estado_id);
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

        public static DataTable GetAllEstados()
        {

            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT EstadoId, Sigla FROM Estado ORDER BY EstadoId ASC");


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

        public static DataTable GetAllCidades(int estado_id)
        {

            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT CidadeId, Nome FROM Cidade WHERE EstadoId = @ESTADO_ID");


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@ESTADO_ID", estado_id);
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
    }
}
