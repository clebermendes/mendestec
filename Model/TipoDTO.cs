using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TipoDTO
    {
        public int codigo { get; set; }
        public string tipo_nome { get; set; }

        public TipoDTO()
        {
            codigo = 0;
            tipo_nome = null;
        }

        
    }
}
