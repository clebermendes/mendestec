using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using Model;

namespace DAO
{
    public class PdfDAO
    {
        public static bool GeneratePDF(string pedido, int pagamento)
        {
            int cont = 0;
            string imgUrl = "C:/Users/Cleber Mendes/Documents/visual studio 2015/Projects/Varejo Tec/Varejo Tec/Imagens/shalom_logo.png";
            string pdfUrl = "C:/Users/Cleber Mendes/Documents/visual studio 2015/Projects/Varejo Tec/Varejo Tec/Vendas";

            Document doc = new Document(PageSize.A6);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(pdfUrl + "/"+pedido+ ".pdf", FileMode.Create));
                doc.Open();

                Image logo_png = Image.GetInstance(imgUrl);
                logo_png.ScaleToFit(125f, 75f);
                logo_png.Alignment = Image.ALIGN_CENTER;

                PdfPTable table = new PdfPTable(4);

                table.TotalWidth = 245f;
                table.LockedWidth = true;

                float[] widths = new float[] { 1f, 2.6f, 1.3f, 1.3f };
                table.SetWidths(widths);
                table.HorizontalAlignment = 0;
                
                PdfPCell img = new PdfPCell(logo_png);
                img.Colspan = 4;
                img.HorizontalAlignment = 1;
                table.AddCell(img);

                PdfPCell numpedido = new PdfPCell(new Phrase("Pedido Nº:"));
                numpedido.Colspan = 2;
                numpedido.HorizontalAlignment = 0;
                table.AddCell(numpedido);

                PdfPCell pedido_ = new PdfPCell(new Phrase(pedido));
                pedido_.Colspan = 2;
                pedido_.HorizontalAlignment = 0;
                table.AddCell(pedido_);


                PdfPCell pgto = new PdfPCell(new Phrase("Pagamento: " +  VendaDAO.GetPaymentName(pagamento)));
                pgto.Colspan = 4;
                pgto.HorizontalAlignment = 0;
                table.AddCell(pgto);

                PdfPCell quant = new PdfPCell(new Phrase("Quant"));
                quant.Colspan = 1;
                quant.HorizontalAlignment = 0;
                table.AddCell(quant);

                PdfPCell descricao = new PdfPCell(new Phrase("Descrição"));
                descricao.Colspan = 1;
                descricao.HorizontalAlignment = 0;
                table.AddCell(descricao);

                PdfPCell preco = new PdfPCell(new Phrase("Preço R$"));
                preco.Colspan = 1;
                preco.HorizontalAlignment = 0;
                table.AddCell(preco);

                PdfPCell total = new PdfPCell(new Phrase("Total R$"));
                total.Colspan = 1;
                total.HorizontalAlignment = 0;
                table.AddCell(total);

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    StringBuilder SQL = new StringBuilder();
                    SQL.Append(@"SELECT p.codBarras,p.codigo, pg.descricao,p.precoFinal, p.produto_nome, v.codigo_venda, v.total, v.qtdeItens FROM Vendas_Produtos as v ");
                    SQL.Append(@"INNER JOIN Produto p ON (v.codigo_produto = p.codigo) ");
                    SQL.Append(@"INNER JOIN Vendas ve ON (v.codigo_venda = ve.codigo) ");
                    SQL.Append(@"INNER JOIN Pagamento pg ON (ve.pagamento_id = pg.codigo) ");
                    SQL.Append(@"WHERE v.codigo_venda = @PEDIDO ");

                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);

                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@PEDIDO", pedido); 
                        using (SqlDataReader rdr = command.ExecuteReader())
                        {
                            while(rdr.Read())
                            {
                                table.AddCell(rdr["qtdeItens"].ToString());
                                table.AddCell(rdr["produto_nome"].ToString());
                                table.AddCell(rdr["precoFinal"].ToString());
                                table.AddCell(rdr["total"].ToString());
                                cont++;
                            }
                            if(cont < 13)
                            {
                                while(cont < 13)
                                {
                                    table.AddCell(" ");
                                    table.AddCell(" ");
                                    table.AddCell(" ");
                                    table.AddCell(" ");
                                    cont++;
                                }
                                PdfPCell total1 = new PdfPCell(new Phrase("Total"));
                                total1.Colspan = 2;
                                total1.HorizontalAlignment = 2;
                                table.AddCell(total1);

                                PdfPCell total2 = new PdfPCell(new Phrase(" "));
                                total2.Colspan = 1;
                                total2.HorizontalAlignment = 0;
                                table.AddCell(total2);

                                PdfPCell total3 = new PdfPCell(new Phrase("R$" + VendaDAO.GetTotalSelling(pedido).ToString("0.00")));
                                total3.Colspan = 1;
                                total3.HorizontalAlignment = 0;
                                table.AddCell(total3);
                            }
                            else
                            {
                                PdfPCell total1 = new PdfPCell(new Phrase("Total"));
                                total1.Colspan = 2;
                                total1.HorizontalAlignment = 2;
                                table.AddCell(total1);

                                PdfPCell total2 = new PdfPCell(new Phrase(" "));
                                total2.Colspan = 1;
                                total2.HorizontalAlignment = 0;
                                table.AddCell(total2);

                                PdfPCell total3 = new PdfPCell(new Phrase("R$" + VendaDAO.GetTotalSelling(pedido).ToString("0.00")));
                                total3.Colspan = 1;
                                total3.HorizontalAlignment = 0;
                                table.AddCell(total3);
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        throw e;
                    }
                }
                doc.Add(table);

                return true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                doc.Close();
                
            }
        }

        public static bool GeneratePDFPedido(string pedido, int codigo)
        {
            int cont = 0;
            string imgUrl = "C:/Users/Cleber Mendes/Documents/visual studio 2015/Projects/Varejo Tec/Varejo Tec/Imagens/shalom_logo.png";
            string imgUrl2 = "C:/Users/Cleber Mendes/Documents/visual studio 2015/Projects/Varejo Tec/Varejo Tec/Imagens/detalhes.png";
            string pdfUrl = "C:/Users/Cleber Mendes/Documents/visual studio 2015/Projects/Varejo Tec/Varejo Tec/Pedidos";

            FornecedorDTO fornecedor = new FornecedorDTO();
            fornecedor = FornecedorDAO.GetFornecedorByCode(codigo);

            Document doc = new Document(PageSize.A4);

            BaseFont titulos = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
            Font title = new Font(titulos, 14, Font.BOLD, BaseColor.BLACK);
            Font body = new Font(titulos, 10, Font.NORMAL, BaseColor.BLACK);

            try
            {
                PdfWriter.GetInstance(doc, new FileStream(pdfUrl + "/" + pedido + ".pdf", FileMode.Create));
                doc.Open();

                Image logo_png = Image.GetInstance(imgUrl);
                logo_png.ScaleToFit(230f, 100f);
                logo_png.Alignment = Image.ALIGN_CENTER;

                Image detalhes = Image.GetInstance(imgUrl2);
                detalhes.ScaleToFit(300f, 200f);
                detalhes.PaddingTop = 100f;
                detalhes.Alignment = Image.ALIGN_CENTER;

                PdfPTable table_fornecedor = new PdfPTable(4);
                PdfPTable table_logo = new PdfPTable(2);
                PdfPTable table_produtos = new PdfPTable(5);

                table_fornecedor.TotalWidth = 520f;
                table_fornecedor.LockedWidth = true;

                table_logo.TotalWidth = 520f;
                table_logo.LockedWidth = true;

                table_produtos.TotalWidth = 520f;
                table_produtos.LockedWidth = true;

                float[] widths = new float[] { 8f, 14f};
                table_logo.SetWidths(widths);
                table_logo.HorizontalAlignment = 0;

                float[] widths2 = new float[] { 5f, 12f, 5f, 8f };
                table_fornecedor.SetWidths(widths2);
                table_fornecedor.HorizontalAlignment = 0;

                float[] widths3 = new float[] { 3.5f,5f, 8f, 7f, 5f };
                table_produtos.SetWidths(widths3);
                table_produtos.HorizontalAlignment = 0;

                PdfPCell img = new PdfPCell(logo_png);
                img.Colspan = 1;
                img.HorizontalAlignment = 1;
                table_logo.AddCell(img);

                PdfPCell img2 = new PdfPCell(detalhes);
                img2.Colspan = 1;
                img2.HorizontalAlignment = 1;
                table_logo.AddCell(img2);

                doc.Add(table_logo);
                doc.Add(new Paragraph("Destinatário/Remetente", title));

                //FIRST LINE
                PdfPCell forne_nome = new PdfPCell(new Phrase("Fornecedor:",body));
                forne_nome.Colspan = 1;
                forne_nome.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_nome);

                PdfPCell forne_nome_ = new PdfPCell(new Phrase(fornecedor.nomeFantasia, body));
                forne_nome_.Colspan = 1;
                forne_nome_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_nome_);

                PdfPCell forne_cnpj = new PdfPCell(new Phrase("CNPJ:", body));
                forne_cnpj.Colspan = 1;
                forne_cnpj.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_cnpj);

                PdfPCell forne_cnpj_ = new PdfPCell(new Phrase(fornecedor.cnpj, body));
                forne_cnpj_.Colspan = 1;
                forne_cnpj_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_cnpj_);
                //SECOND LINE
                PdfPCell forne_endereco = new PdfPCell(new Phrase("Endereço:", body));
                forne_endereco.Colspan = 1;
                forne_endereco.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_endereco);

                PdfPCell forne_endereco_ = new PdfPCell(new Phrase(fornecedor.complemento + ",Nº " + fornecedor.numero, body));
                forne_endereco_.Colspan = 1;
                forne_endereco_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_endereco_);

                PdfPCell forne_bairro = new PdfPCell(new Phrase("Bairro:", body));
                forne_bairro.Colspan = 1;
                forne_bairro.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_bairro);

                PdfPCell forne_bairro_ = new PdfPCell(new Phrase(fornecedor.bairro, body));
                forne_bairro_.Colspan = 1;
                forne_bairro_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_bairro_);

                //THIRD LINE
                PdfPCell forne_cidade= new PdfPCell(new Phrase("Cidade:", body));
                forne_cidade.Colspan = 1;
                forne_cidade.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_cidade);

                PdfPCell forne_cidade_ = new PdfPCell(new Phrase(fornecedor.cidade.nome, body));
                forne_cidade_.Colspan = 1;
                forne_cidade_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_cidade_);

                PdfPCell forne_estado = new PdfPCell(new Phrase("UF:", body));
                forne_estado.Colspan = 1;
                forne_estado.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_estado);

                PdfPCell forne_estado_ = new PdfPCell(new Phrase(fornecedor.cidade.estado.sigla, body));
                forne_estado_.Colspan = 1;
                forne_estado_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_estado_);

                //FOURTH LINE
                PdfPCell forne_contato = new PdfPCell(new Phrase("Telefone:", body));
                forne_contato.Colspan = 1;
                forne_contato.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_contato);

                PdfPCell forne_contato_ = new PdfPCell(new Phrase(fornecedor.telefone, body));
                forne_contato_.Colspan = 1;
                forne_contato_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_contato_);

                PdfPCell forne_email = new PdfPCell(new Phrase("E-mail:", body));
                forne_email.Colspan = 1;
                forne_email.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_email);

                PdfPCell forne_email_ = new PdfPCell(new Phrase(fornecedor.email, body));
                forne_email_.Colspan = 1;
                forne_email_.HorizontalAlignment = 0;
                table_fornecedor.AddCell(forne_email_);

                doc.Add(table_fornecedor);
                doc.Add(new Paragraph("Produtos", title));

                PdfPCell quant = new PdfPCell(new Phrase("Quant", title));
                quant.Colspan = 1;
                quant.HorizontalAlignment = 0;
                table_produtos.AddCell(quant);

                PdfPCell referencia = new PdfPCell(new Phrase("Referência", title));
                referencia.Colspan = 1;
                referencia.HorizontalAlignment = 0;
                table_produtos.AddCell(referencia);

                PdfPCell descricao = new PdfPCell(new Phrase("Descrição", title));
                descricao.Colspan = 1;
                descricao.HorizontalAlignment = 0;
                table_produtos.AddCell(descricao);

                PdfPCell preco = new PdfPCell(new Phrase("Preço Unit. R$", title));
                preco.Colspan = 1;
                preco.HorizontalAlignment = 0;
                table_produtos.AddCell(preco);

                PdfPCell total = new PdfPCell(new Phrase("Total R$", title));
                total.Colspan = 1;
                total.HorizontalAlignment = 0;
                table_produtos.AddCell(total);


                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Mendes_varejo"].ConnectionString))
                {
                    StringBuilder SQL = new StringBuilder();
                    SQL.Append(@"SELECT p.codBarras,p.codigo, p.produto_nome,p.cod_ref, pp.codigo_pedido, pp.qtdeItens, p.precoInicial, pp.total FROM Pedidos_Produtos as pp ");
                    SQL.Append(@"INNER JOIN Produto p ON (pp.codigo_produto = p.codigo) ");
                    SQL.Append(@"INNER JOIN Pedidos pe ON (pp.codigo_pedido = pe.codigo) ");
                    SQL.Append(@"INNER JOIN Fornecedor fo ON (pe.fornecedor_id = fo.codigo) ");
                    SQL.Append(@"WHERE pp.codigo_pedido = @PEDIDO ");


                    SqlCommand command = new SqlCommand(SQL.ToString(), connection);

                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@PEDIDO", pedido);
                        using (SqlDataReader rdr = command.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                table_produtos.AddCell(rdr["qtdeItens"].ToString());
                                table_produtos.AddCell(rdr["cod_ref"].ToString());
                                table_produtos.AddCell(rdr["produto_nome"].ToString());
                                table_produtos.AddCell(rdr["precoInicial"].ToString());
                                table_produtos.AddCell(rdr["total"].ToString());
                                cont++;
                            }
                            if (cont < 20)
                            {
                                while (cont < 20)
                                {
                                    table_produtos.AddCell(" ");
                                    table_produtos.AddCell(" ");
                                    table_produtos.AddCell(" ");
                                    table_produtos.AddCell(" ");
                                    table_produtos.AddCell(" ");
                                    cont++;
                                }
                                PdfPCell total1 = new PdfPCell(new Phrase("Total", body));
                                total1.Colspan = 3;
                                total1.HorizontalAlignment = 2;
                                table_produtos.AddCell(total1);

                                PdfPCell total2 = new PdfPCell(new Phrase(" "));
                                total2.Colspan = 1;
                                total2.HorizontalAlignment = 0;
                                table_produtos.AddCell(total2);

                                PdfPCell total3 = new PdfPCell(new Phrase("R$" + PedidoDAO.GetTotalPedido(pedido).ToString(), body));
                                total3.Colspan = 1;
                                total3.HorizontalAlignment = 0;
                                table_produtos.AddCell(total3);
                            }
                            else
                            {
                                PdfPCell total1 = new PdfPCell(new Phrase("Total", body));
                                total1.Colspan = 3;
                                total1.HorizontalAlignment = 2;
                                table_produtos.AddCell(total1);

                                PdfPCell total2 = new PdfPCell(new Phrase(" "));
                                total2.Colspan = 1;
                                total2.HorizontalAlignment = 0;
                                table_produtos.AddCell(total2);

                                PdfPCell total3 = new PdfPCell(new Phrase("R$" + PedidoDAO.GetTotalPedido(pedido).ToString(), body));
                                total3.Colspan = 1;
                                total3.HorizontalAlignment = 0;
                                table_produtos.AddCell(total3);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                doc.Add(table_produtos);

                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                doc.Close();

            }


        }

    }
}
