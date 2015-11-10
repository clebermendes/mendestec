using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model;
using System.Drawing;
using System.IO;
using System.Data;

namespace DAO
{
    public class ProdutoDAO
    {
        public static DataTable GetProducts()
        {
            DataTable produtos = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT p.codBarras as CÓDIGO, p.produto_nome as DESCRIÇÃO, t.nome_tipo as TIPO, f.nome as FORNECEDOR, p.tamanho as TAMANHO, p.qtde as ESTOQUE, p.precoFinal as PREÇO");
            SQL.Append(@" FROM Produto p");
            SQL.Append(@" INNER JOIN Fornecedor f ON (p.fornecedor_id = f.codigo)");
            SQL.Append(@" INNER JOIN Tipo t ON (p.tipo_id = t.codigo)");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(produtos);
                }
                return produtos;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public static ProdutoDTO GetProductByCode(string code)
        {
            ProdutoDTO produto = new ProdutoDTO();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT * FROM Produto");
            SQL.Append(@" WHERE codBarras = @CODIGO");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", code);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produto.codBarras = (reader["codBarras"]).ToString();
                            produto.codigo = (reader["codigo"]).ToString();
                            produto.code_ref = Convert.ToInt64(reader["cod_ref"]);
                            produto.descricao = (reader["produto_nome"]).ToString();
                            produto.qtde = Convert.ToInt32(reader["qtde"]);
                            produto.fornecedor.codigo = Convert.ToInt32(reader["fornecedor_id"]);
                            produto.precoFinal = Convert.ToDouble(reader["precoFinal"]);
                            produto.precoInicial = Convert.ToDouble(reader["precoInicial"]);
                            produto.tamanho = (reader["tamanho"]).ToString();
                            produto.tipo.codigo = Convert.ToInt32(reader["tipo_id"]);
                            produto.imagem = (byte[])(reader["imagem"]);
                        }
                    }
                }
                return produto;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public static ProdutoDTO GetProductByCodeWithoutImage(string code)
        {
            ProdutoDTO produto = new ProdutoDTO();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT codigo,cod_ref,codBarras,produto_nome,fornecedor_id,qtde,precoFinal,precoInicial,tamanho,tipo_id FROM Produto");
            SQL.Append(@" WHERE codBarras = @CODIGO");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", code);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produto.codBarras = (reader["codBarras"]).ToString();
                            produto.codigo = (reader["codigo"]).ToString();
                            produto.code_ref = Convert.ToInt64(reader["cod_ref"]);
                            produto.descricao = (reader["produto_nome"]).ToString();
                            produto.qtde = Convert.ToInt32(reader["qtde"]);
                            produto.fornecedor.codigo = Convert.ToInt32(reader["fornecedor_id"]);
                            produto.precoFinal = Convert.ToDouble(reader["precoFinal"]);
                            produto.precoInicial = Convert.ToDouble(reader["precoInicial"]);
                            produto.tamanho = (reader["tamanho"]).ToString();
                            produto.tipo.codigo = Convert.ToInt32(reader["tipo_id"]);
                        }
                    }
                }
                return produto;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public static List<ProdutoDTO> GetAllProductsCode()
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT codBarras FROM Produto");
            

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
                            ProdutoDTO produto = new ProdutoDTO();
                            produto.codBarras = ((reader["codBarras"]).ToString());
                            produtos.Add(produto);
                        }
                    }
                }
                return produtos;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public static List<ProdutoDTO> GetAllProductsCodeRef(string value)
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT cod_ref FROM Produto WHERE fornecedor_id = @FORNECEDOR");


            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@FORNECEDOR", value);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProdutoDTO produto = new ProdutoDTO();
                            produto.code_ref = Convert.ToInt64(reader["cod_ref"]);
                            produtos.Add(produto);
                        }
                    }
                }
                return produtos;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public static List<ProdutoDTO> GetAllProducts()
        {
            List<ProdutoDTO> retorno = new List<ProdutoDTO>();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT codBarras, produto_nome, qtde, preco FROM Produto");
            

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
                            ProdutoDTO produto = new ProdutoDTO();
                            produto.codBarras = (reader["codBarras"]).ToString();
                            produto.descricao = Convert.ToString(reader["produto_nome"]);
                            produto.qtde = (Convert.ToInt32(reader["qtde"]));
                            produto.precoInicial = ((float)(reader["precoInicial"]));
                            produto.precoFinal = ((float)(reader["precoFinal"])); ;
                            retorno.Add(produto);
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

        public static DataTable GetProductByFilter(string codigo, string tamanho, string descricao)
        {
            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            string query = string.Empty;

            if (!(string.IsNullOrWhiteSpace(codigo)))
            {
                query += "codBarras = @CODIGO AND ";
            }

            if (!(string.IsNullOrWhiteSpace(descricao)))
            {
                query += "produto_nome = '%@DESCRICAO'% AND ";
            }

            if (!(string.IsNullOrWhiteSpace(tamanho)))
            {
                query += "tamanho = @TAMANHO AND ";
            }

            int count = query.Count();
            count = count - 4;
            query = query.Remove(count, 4);


            SQL.Append(@"SELECT codBarras as CÓDIGO, produto_nome as DESCRIÇÃO, t.nome_tipo as TIPO, nome as FORNECEDOR, qtde as ESTOQUE, precoFinal as PREÇO, tamanho as TAMANHO FROM Produto ");
            SQL.Append(@"INNER JOIN Fornecedor as f ON(fornecedor_id = f.codigo) ");
            SQL.Append(@"INNER JOIN Tipo as t ON (tipo_id = t.codigo) ");
            SQL.Append(@"WHERE " + query);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", codigo);
                    command.Parameters.AddWithValue("@DESCRICAO", descricao);
                    command.Parameters.AddWithValue("@TAMANHO", tamanho);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(retorno);
                }
                return retorno;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }

        }

        public static DataTable GetProductByFilter(int tipo_id, string codigo, string tamanho, string descricao)
        {

            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            string query = string.Empty;

            if (!(tipo_id.Equals(0)))
            {
                query += "tipo_id = @TIPO_ID AND ";
            }

            if (!(string.IsNullOrWhiteSpace(codigo)))
            {
                query += "codBarras = @CODIGO AND "; 
            }

            if (!(string.IsNullOrWhiteSpace(descricao)))
            {
                query += "produto_nome = @DESCRICAO AND ";
               
            }

            if (!(string.IsNullOrWhiteSpace(tamanho)))
            {
                query += "tamanho = @TAMANHO AND ";
            }

            int count = query.Count();
            count = count - 4;
            query = query.Remove(count, 4);


            SQL.Append(@"SELECT codBarras as CÓDIGO, produto_nome as DESCRIÇÃO, t.nome_tipo as TIPO, nome as FORNECEDOR, qtde as ESTOQUE, precoFinal as PREÇO, tamanho as TAMANHO FROM Produto ");
            SQL.Append(@"INNER JOIN Fornecedor as f ON(fornecedor_id = f.codigo) ");
            SQL.Append(@"INNER JOIN Tipo as t ON (tipo_id = t.codigo) ");
            SQL.Append(@"WHERE " + query);

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@TIPO_ID", tipo_id);
                    command.Parameters.AddWithValue("@CODIGO", codigo);
                    command.Parameters.AddWithValue("@DESCRICAO", descricao);
                    command.Parameters.AddWithValue("@TAMANHO", tamanho);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(retorno);
                }
                return retorno;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }

        }


        public static void DeleteProduct(ProdutoDTO produto)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" DELETE FROM Produto WHERE codigo = @CODIGO");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", produto.codigo);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception Erro)
            {
                throw Erro;
            }

        }

        public static bool UpdateProduct(ProdutoDTO produto)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"UPDATE Produto SET produto_nome = @DESCRICAO");
                SQL.Append(@"WHERE codigo = @CODIGO");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
                    command.Parameters.AddWithValue("@CODIGO", produto.codigo);
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

        public static bool InsertProduct(ProdutoDTO produto, byte[] imagem)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"INSERT INTO Produto (codigo,codBarras,cod_ref, produto_nome, fornecedor_id, qtde,precoFinal,precoInicial, tamanho,tipo_id, imagem) ");
                SQL.Append(@"VALUES (NEXT VALUE FOR dbo.Sequence_Produto_interno,NEXT VALUE FOR dbo.Sequence_Produto,@COD_REF,@DESCRICAO,@FORNECEDOR_ID,@QTDE,@PRECOFINAL,@PRECOINICIAL,@TAMANHO,@TIPO_ID, @IMAGEM) ");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@COD_REF", produto.code_ref);
                    command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
                    command.Parameters.AddWithValue("@FORNECEDOR_ID", produto.fornecedor.codigo);
                    command.Parameters.AddWithValue("@QTDE", produto.qtde);
                    command.Parameters.AddWithValue("@PRECOFINAL", produto.precoFinal);
                    command.Parameters.AddWithValue("@PRECOINICIAL", produto.precoInicial);
                    command.Parameters.AddWithValue("@TAMANHO", produto.tamanho);
                    command.Parameters.AddWithValue("@TIPO_ID", produto.tipo.codigo);
                    command.Parameters.AddWithValue("@IMAGEM", imagem);
                    command.ExecuteNonQuery();
                    command.Dispose();

                }
                return true;
            }
            catch(Exception erro)
            {
                throw erro;
            }

            
        }

        public static bool UpdateProduct(ProdutoDTO produto, byte[] imagem)
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"UPDATE Produto SET produto_nome=@DESCRICAO, fornecedor_id=@FORNECEDOR_ID, qtde=@QTDE,precoFinal=@PRECOFINAL,precoInicial=@PRECOINICIAL,tamanho=@TAMANHO,tipo_id=@TIPO_ID, imagem=@IMAGEM ");
                SQL.Append(@"WHERE codBarras=@CODIGO ");


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", produto.codBarras);
                    command.Parameters.AddWithValue("@DESCRICAO", produto.descricao);
                    command.Parameters.AddWithValue("@FORNECEDOR_ID", produto.fornecedor.codigo);
                    command.Parameters.AddWithValue("@QTDE", produto.qtde);
                    command.Parameters.AddWithValue("@PRECOFINAL", produto.precoFinal);
                    command.Parameters.AddWithValue("@PRECOINICIAL", produto.precoInicial);
                    command.Parameters.AddWithValue("@TAMANHO", produto.tamanho);
                    command.Parameters.AddWithValue("@TIPO_ID", produto.tipo.codigo);
                    command.Parameters.AddWithValue("@IMAGEM", imagem);
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

        public static double GetLastBarCode()
        {
            try
            {
                double codigo = 0;
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT MAX(codBarras) as codBarras FROM Produto");


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
                            codigo = Convert.ToDouble(reader["codBarras"]);
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

        public static bool UpdatingProductQuantify(string codigo, int quantidade)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"UPDATE Produto SET qtde = qtde - @QUANTIDADE WHERE codigo = @CODIGO");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_Varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(),connection);
                    command.Parameters.AddWithValue("@CODIGO", Convert.ToInt32(codigo));
                    command.Parameters.AddWithValue("@QUANTIDADE", quantidade);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool CheckFornecedorProduto(long cod_ref, int fornecedor)
        {
            try
            {
                string code = null;
                StringBuilder SQL = new StringBuilder();
                SQL.Append("SELECT cod_ref FROM Produto ");
                SQL.Append(@"WHERE cod_ref = @CODIGO and fornecedor_id = @FORNECEDOR");

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", cod_ref);
                    command.Parameters.AddWithValue("@FORNECEDOR", fornecedor);
                    command.ExecuteNonQuery();
                    command.Dispose();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            code = Convert.ToString(reader["cod_ref"]);
                        }
                    }
                }
                return true;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
