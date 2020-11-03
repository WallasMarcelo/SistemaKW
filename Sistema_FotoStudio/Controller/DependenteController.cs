using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class DependenteController
    {
        public DataTable TrazerAniversariantes(String date)
        {
            Dependente dependente = new Dependente();
            return dependente.TrazerDependente(date);

        } 
    }
}
