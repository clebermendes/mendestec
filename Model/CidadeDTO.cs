using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CidadeDTO
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public EstadoDTO estado { get; set; }

        public CidadeDTO()
        {
            codigo = 0;
            nome = null;
            estado = new EstadoDTO();   
        }


    }
}
