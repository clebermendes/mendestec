using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string senha { get; set; }
        public string nomeCompleto { get; set; }
        public string login { get; set; }
        public string cpf { get; set; }

        public UsuarioDTO()
        {
            id = 0;
            senha = null;
            nomeCompleto = null;
            login = null;
            cpf = null;
        }
        
    }

    
}
