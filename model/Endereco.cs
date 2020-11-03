using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Endereco : Telefone
    {
        public String Logradouro { get; set; }
        public int Numero { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String CEP { get; set; }
        public String UF { get; set; }

      /*  public Endereco(String Logradouro, int Numero, String Bairro, String Cidade, String CEP, String UF) : base()
        {
            this.Logradouro = Logradouro;
            this.Numero = Numero;
            this.Bairro = Bairro;
            this.Cidade = Cidade;
            this.CEP = CEP;
            this.UF = UF;
        }*/



    }
}
