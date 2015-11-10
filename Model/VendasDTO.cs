using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VendasDTO
    {
        public string codigo { get; set; }
        public DateTime dataEmissao { get; set; }
        public double total { get; set; }
        public int tipoPagamento { get; set; }

        public VendasDTO()
        {
            codigo = null;
            total = 0;
            tipoPagamento = 0;
        }
    }
}
