using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PedidoDTO
    {
        public string codigo { get; set; }
        public DateTime dataEmissao { get; set; }
        public double total { get; set; }
        public FornecedorDTO fornecedor { get; set; }

        public PedidoDTO()
        {
            codigo = null;
            total = 0;
            fornecedor = new FornecedorDTO();
        }
    }
}
