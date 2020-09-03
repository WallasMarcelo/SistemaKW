using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class BuscaCEPController
    {
        public String cep { get; set; }

        public CEP solicitarCEP(String cep)
        {
            BuscaCEP buscar = new BuscaCEP();
            return buscar.SolitarCEP(cep);

        } 

    }
}
