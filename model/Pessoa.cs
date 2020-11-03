using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Pessoa : Endereco
    {
        public String CPF { get; set; }
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime Data_Nasc { get; set; }
        public String RG { get; set; }
        public int Situação { get; set; }
        public String Sexo { get; set; }


        public Pessoa(String CPF, String Nome, String Sobrenom, DateTime Data_Nasc, String RG, int Situação, String Sexo) : base()
        {
            this.CPF = CPF;
            this.Nome = Nome;
            this.Data_Nasc = Data_Nasc;
            this.Sobrenome = Sobrenome;
            this.RG = RG;
            this.Situação = Situação;
            this.Sexo = Sexo;
        }

        public Pessoa() : base()
        {
        }
    }
}
