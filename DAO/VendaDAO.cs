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
    public class VendaDAO
    {
        public static DataTable GetAllSellingsFromToday()
        {
            DataTable produtos = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT v.codigo as CODIGO_VENDA, v.valorTotal as VALOR_TOTAL, p.descricao as FORMA_DE_PAGAMENTO FROM Vendas v ");
            SQL.Append(@"INNER JOIN Pagamento p ON (v.pagamento_id = p.codigo) ");
            SQL.Append(@"WHERE dataEmissao = CONVERT(date, getdate()) ");

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

        public static double GetLastCodeSelling()
        {
            try
            {
                double codigo = 0;
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT MAX(codigo) as codigo FROM Vendas");


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

        public static DataTable GetPaymentWays()
        {
            DataTable pagamento = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT codigo, descricao");
            SQL.Append(@" FROM Pagamento");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(pagamento);
                }
                return pagamento;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }

        public static bool InsertSelling(VendasDTO venda)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"INSERT INTO Vendas (codigo,dataEmissao, valorTotal, pagamento_id) VALUES (NEXT VALUE FOR dbo.Sequence_Vendas,CONVERT (date,GETDATE()), @VALORTOTAL, @PAGAMENTO_ID)");
            
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_Varejo"].ConnectionString))
                {
                        connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@VALORTOTAL", venda.total);
                    command.Parameters.AddWithValue("@PAGAMENTO_ID", venda.tipoPagamento);
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

        public static bool InsertingProductInSelling(VendaProdutoDTO venda)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"INSERT INTO Vendas_Produtos(codigo_produto, codigo_venda, total, qtdeItens) VALUES(@CODIGO_PRODUTO, @CODIGO_VENDA, @TOTAL, @QTDE)");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_Varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO_PRODUTO", venda.codigo_produto);
                    command.Parameters.AddWithValue("@CODIGO_VENDA", venda.codigo_venda);
                    command.Parameters.AddWithValue("@TOTAL", venda.total);
                    command.Parameters.AddWithValue("@QTDE", venda.quantidade_ites);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                return true;
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        public static DataTable GetSellingBySellingCode(string pedido)
        {
            DataTable data = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT p.codBarras as CÓDIGO_DE_BARRAS, v.qtdeItens AS QUANTIDADE, p.produto_nome as DESCRICAO, v.total AS TOTAL FROM Vendas_Produtos as v ");
            SQL.Append(@"INNER JOIN Produto p ON (v.codigo_produto = p.codigo) ");
            SQL.Append(@"WHERE v.codigo_venda = @PEDIDO ");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@PEDIDO", pedido);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                return data;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingByCode(string codigo)
        {
            DataTable data = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT v.codigo as CÓDIGO, v.dataEmissao as DATA, p.descricao as PAGAMENTO, v.valorTotal as TOTAL FROM Vendas v ");
            SQL.Append(@" INNER JOIN Pagamento p ON (v.pagamento_id = p.codigo) ");
            SQL.Append(@" WHERE v.codigo = @CODIGO");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", codigo);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                return data;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static VendasDTO GetSellingByCode2(string codigo)
        {
            VendasDTO venda = new VendasDTO();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT codigo, dataEmissao, pagamento_id, valorTotal FROM Vendas  ");
            SQL.Append(@" WHERE codigo = @CODIGO");

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
                            venda.codigo = dr["codigo"].ToString();
                            venda.dataEmissao = Convert.ToDateTime(dr["dataEmissao"]);
                            venda.tipoPagamento = Convert.ToInt32(dr["pagamento_id"]);
                            venda.total = Convert.ToDouble(dr["valorTotal"]);
                        }

                    }
                }
                return venda;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingByDate(string dataInicial, string dataFinal)
        {
            DataTable data = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT v.codigo as CÓDIGO, v.dataEmissao as DATA, p.descricao as PAGAMENTO, v.valorTotal as TOTAL FROM Vendas v ");
            SQL.Append(@" INNER JOIN Pagamento p ON (v.pagamento_id = p.codigo) ");
            SQL.Append(@" WHERE v.dataEmissao BETWEEN @DATAINICIAL AND @DATAFINAL");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@DATAINICIAL", dataInicial);
                    command.Parameters.AddWithValue("@DATAFINAL", dataFinal);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingByDate(string dataInicial)
        {
            DataTable data = new DataTable();
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" SELECT v.codigo as CÓDIGO, v.dataEmissao as DATA, p.descricao as PAGAMENTO, v.valorTotal as TOTAL FROM Vendas v ");
            SQL.Append(@" INNER JOIN Pagamento p ON (v.pagamento_id = p.codigo) ");
            SQL.Append(@" WHERE v.dataEmissao=@DATAINICIAL");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@DATAINICIAL", dataInicial);
                    command.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                }
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string GetPaymentName(int codigo)
        {
            string descricao = null;
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT descricao FROM Pagamento WHERE codigo = @CODIGO ");

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);
                    command.Parameters.AddWithValue("@CODIGO", codigo);

                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            descricao = (dr["descricao"].ToString());
                        }
                        
                    }
                }
                return descricao;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static double GetTotalSelling(string codigo)
        {
            double descricao = 0;
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@"SELECT valorTotal FROM Vendas WHERE codigo = @CODIGO ");

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
