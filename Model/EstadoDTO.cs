using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EstadoDTO
    {
        public int codigo { get; set; }
        public string sigla { get; set; }

        public EstadoDTO()
        {
            codigo = 0;
            sigla = null;
        }
    }
}
