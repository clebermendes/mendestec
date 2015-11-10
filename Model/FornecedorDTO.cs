using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class FornecedorDTO
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string nomeFantasia { get; set; }
        public string cnpj { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public int cidade_id { get; set; }
        public byte estado_id{ get; set; }
        public CidadeDTO cidade { get; set; }


        public FornecedorDTO()
        {
            codigo = 0;
            nome = null;
            nomeFantasia = null;
            cnpj = null;
            telefone = null;
            email = null;
            complemento = null;
            bairro = null;
            numero = null;
            cep = null;
            cidade_id = 0;
            estado_id = 0;
            cidade = new CidadeDTO();
        }
    }
}
