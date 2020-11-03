using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Telefone : Email
    {
        public String telefone { get; set; }
        public String celular { get; set; }
        public int tipo_telefone { get; set; }


       /* public Telefone(String telefone, int tipo_telefon) 
        {
            this.telefone = telefone;
            this.tipo_telefone = tipo_telefone;
        }*/
    }
}
