using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Model;

namespace Business
{
    public class GeralRN
    {

        #region Produtos
        public static DataTable GetProducts()
        {
            try
            {
                return ProdutoDAO.GetProducts();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static ProdutoDTO GetProductByCodeWithoutImage(string codigo)
        {
            try
            {
                return ProdutoDAO.GetProductByCodeWithoutImage(codigo);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static ProdutoDTO GetProductByCode(string codigo)
        {
            try
            {
                return ProdutoDAO.GetProductByCode(codigo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static List<ProdutoDTO> GetAllProducts()
        {
            try
            {
                return ProdutoDAO.GetAllProducts();
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        public static List<ProdutoDTO> GetAllProductsCode()
        {
            try
            {
                return ProdutoDAO.GetAllProductsCode();
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        public static List<ProdutoDTO> GetAllProductsCodeRef(string value)
        {
            try
            {
                return ProdutoDAO.GetAllProductsCodeRef(value);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public static bool CheckFornecedorProduto(long cod, int fornecedor)
        {
            try
            {
                return ProdutoDAO.CheckFornecedorProduto(cod, fornecedor);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetProductbyFilter(string codigo, string tamanho, string descricao)
        {
            try
            {
                return ProdutoDAO.GetProductByFilter(codigo, tamanho, descricao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetProductbyFilter(int tipo_id, string codigo, string tamanho, string descricao)
        {
            try
            {
                return ProdutoDAO.GetProductByFilter(tipo_id, codigo, tamanho, descricao);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        
        public static bool InsertProduct(ProdutoDTO produto, byte[] imagem)
        {
            try
            {
                return ProdutoDAO.InsertProduct(produto, imagem);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool UpdateProduct(ProdutoDTO produto, byte[] imagem)
        {
            try
            {
                return ProdutoDAO.UpdateProduct(produto, imagem);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public static double GetLastBarCode()
        {
            try
            {
                return ProdutoDAO.GetLastBarCode();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public static void EditProduct()
        {
            try
            {

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool EditProductName(ProdutoDTO produto)
        {
            try
            {
                return ProdutoDAO.UpdateProduct(produto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool UpdatingProductQuantify(string codigo, int quantidade)
        {
            try
            {
                return ProdutoDAO.UpdatingProductQuantify(codigo, quantidade);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        #endregion

        #region Fornecedores
        //FORNECEDORES
        public static DataTable GetAllFornecedores()
        {
            try
            {
                return FornecedorDAO.GetAllFornecedores();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static double GetLastBarCodeForne()
        {
            try
            {
                return FornecedorDAO.GetLastBarCode();
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
                return FornecedorDAO.InsertFornecedor(fornecedor);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public static DataTable GetAllCidades(int estado_id)
        {
            try
            {
                return FornecedorDAO.GetAllCidades(estado_id);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetAllEstados()
        {
            try
            {
                return FornecedorDAO.GetAllEstados();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region Usuario
        public static int ChecarLogin(string login, string senha)
        {
            try
            {
                return UsuarioDAO.ChecarLogin(login, senha);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool InsertUser(UsuarioDTO usuario)
        {
            try
            {
                return UsuarioDAO.InsertUser(usuario);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static List<UsuarioDTO> GetAllUsers()
        {
            try
            {
                return UsuarioDAO.GetAllUsers();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public static bool DeleteUser(string nome, string id)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        //public static bool EditUser(string nome, string cpf, string login, string senha)
        //{
        //    try
        //    {

        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}

        #endregion

        #region Tipo

        public static DataTable GetTipos()
        {
            try
            {
                return TipoDAO.GetAllTipos();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public static bool InsertType(TipoDTO tipo)
        {
            try
            {
                return TipoDAO.InsertType(tipo);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static double GetLastCodeType()
        {
            try
            {
                return TipoDAO.GetLastCodeType();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        #endregion
        
        #region Venda

        public static double GetLastBarCodePedido()
        {
            try
            {
                return VendaDAO.GetLastCodeSelling();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static DataTable GetPaymentWays()
        {
            try
            {
                return VendaDAO.GetPaymentWays();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static bool InsertSelling(VendasDTO venda)
        {
            try
            {
                 return VendaDAO.InsertSelling(venda);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static bool InsertingProductInSelling(VendaProdutoDTO venda)
        {
            try
            {
                return VendaDAO.InsertingProductInSelling(venda);
            }
            catch(Exception e)
            {
                throw e;    
            }
        }

        public static string GetPaymentName(int codigo)
        {
            try
            {
                return VendaDAO.GetPaymentName(codigo);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetAllSellingsFromToday()
        {
            try
            {
                return VendaDAO.GetAllSellingsFromToday();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingByDate(string dataInicial)
        {
            try
            {
                return VendaDAO.GetSellingByDate(dataInicial);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingByDate(string dataInicial, string dataFinal)
        {
            try
            {
                return VendaDAO.GetSellingByDate(dataInicial, dataFinal);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingByCode(string codigo)
        {
            try
            {
                return VendaDAO.GetSellingByCode(codigo);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static VendasDTO GetSellingByCode2(string codigo)
        {
            try
            {
                return VendaDAO.GetSellingByCode2(codigo);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static DataTable GetSellingBySellingCode(string pedido)
        {
            try
            {
                return VendaDAO.GetSellingBySellingCode(pedido);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region Pedido

        public static DataTable GetAllPedidos()
        {
            try
            {
                return PedidoDAO.GetAllPedidos();
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
                return PedidoDAO.GetLastCodePedido();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public static bool InsertPedido(PedidoDTO pedido)
        {
            try
            {
                return PedidoDAO.InsertPedido(pedido);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static bool InsertingProductInPedido(PedidoProdutosDTO pedido)
        {
            try
            {
                return PedidoDAO.InsertingProductInPedido(pedido);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion

        #region PDF

        public static bool GeneratePdf(string pedido, int pagamento)
        {
            try
            {
                return PdfDAO.GeneratePDF(pedido, pagamento);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public static bool GeneratePdfPedido(string pedido, int fornecedor)
        {
            try
            {
                return PdfDAO.GeneratePDFPedido(pedido, fornecedor);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        #endregion



    }
}
