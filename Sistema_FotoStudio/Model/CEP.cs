using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
   
    public class CEP
    {
       
        public String cep { get; set; }
        public String logradouro { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }
        public String uf { get; set; }

        public CEP(String cep)
        {
            this.cep = cep;
        }

    }
}
