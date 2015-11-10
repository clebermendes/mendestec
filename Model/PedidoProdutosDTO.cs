using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PedidoProdutosDTO
    {
        public string codigo_pedido { get; set; }
        public string codigo_produto { get; set; }
        public double total { get; set; }
        public int quantidade_ites { get; set; }

        public PedidoProdutosDTO()
        {
            codigo_pedido = null;
            codigo_produto = null;
            total = 0;
            quantidade_ites = 0;
        }
    }
}
