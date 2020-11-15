using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class pesquisaUsuarioController
    {
        public DataTable pesquisaPorCodigo(String Codigo)
        {
            Usuario usuario = new Usuario();
            return usuario.PesquisarPorCodigoTabela(Codigo);

        }

        public DataTable pesquisaPorNome(String Nome)
        {
            Usuario usuario = new Usuario();
            return usuario.PesquisarPorNome(Nome);
        }
    }
}
