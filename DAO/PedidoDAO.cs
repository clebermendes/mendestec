using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DAO
{
    public class PedidoDAO
    {
        public static DataTable GetAllPedidos()
        {
            DataTable retorno = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT p.codigo, p.dataEmissao, p.valorTotal, f.nome FROM Pedidos p ");
            SQL.Append(@"INNER JOIN Fornecedor f ON (p.fornecedor_id = f.codigo ");
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
                return retorno;
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        public static double GetLastCodePedido()
        {
            try
            {
                double codigo = 0;
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT MAX(codigo) as codigo FROM Pedidos");


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

        public static bool InsertPedido(PedidoDTO pedido)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"INSERT INTO Pedidos (codigo,dataEmissao, valorTotal, fornecedor_id) VALUES (NEXT VALUE FOR dbo.Sequence_Pedido,CONVERT (date,GETDATE()), @VALORTOTAL, @FORNECEDOR_ID)");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_Varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@VALORTOTAL", pedido.total);
                    command.Parameters.AddWithValue("@FORNECEDOR_ID", pedido.fornecedor.codigo);
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

        public static bool InsertingProductInPedido(PedidoProdutosDTO pedido)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"INSERT INTO Pedidos_Produtos(codigo_produto, codigo_pedido, total, qtdeItens) VALUES(@CODIGO_PRODUTO, @CODIGO_PEDIDO, @TOTAL, @QTDE)");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_Varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO_PRODUTO", pedido.codigo_produto);
                    command.Parameters.AddWithValue("@CODIGO_PEDIDO", pedido.codigo_pedido);
                    command.Parameters.AddWithValue("@TOTAL", pedido.total);
                    command.Parameters.AddWithValue("@QTDE", pedido.quantidade_ites);
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

        public static double GetTotalPedido(string codigo)
        {
            double descricao = 0;
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT valorTotal FROM Pedidos WHERE codigo = @CODIGO ");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", codigo);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            descricao = Convert.ToDouble(dr["valorTotal"]);
                        }

                    }
                }
                return descricao;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
