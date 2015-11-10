using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VendaProdutoDTO
    {
        public string codigo_venda { get; set; }
        public string codigo_produto { get; set; }
        public double total { get; set; }
        public int quantidade_ites { get; set; }

        public VendaProdutoDTO()
        {
            codigo_venda = null;
            codigo_produto = null;
            total = 0;
            quantidade_ites = 0;
        }
    }
}
