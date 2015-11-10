using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProdutoDTO
    {
        public string codigo { get; set; }
        public string codBarras { get; set; }
        public long code_ref { get; set; }
        public string descricao { get; set; }
        public double desconto { get; set; }
        public int qtde { get; set; }
        public double precoInicial { get; set; }
        public double precoFinal { get; set; }
        public TipoDTO tipo { get; set; }
        public FornecedorDTO fornecedor { get; set; }
        public string tamanho { get; set; }
        public byte[] imagem;

        public ProdutoDTO()
        {
            codigo = null;
            codBarras = null;
            code_ref = 0;
            descricao = null;
            desconto = 0;
            qtde = 0;
            precoInicial = 0;
            precoFinal = 0;
            tamanho = null;
            imagem = null;

            tipo = new TipoDTO();
            fornecedor = new FornecedorDTO();

        }



    }
}
