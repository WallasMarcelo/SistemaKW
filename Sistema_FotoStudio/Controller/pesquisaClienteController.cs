using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class pesquisaClienteController
    {
        public DataTable pesquisaPorCPF(String CPF)
        {
            Cliente cliente = new Cliente();
            return cliente.PesquisarPorCPFTabela(CPF);

        } 

        public DataTable pesquisaPorNome(String Nome)
        {
            Cliente cliente = new Cliente();
            return cliente.PesquisarPorNome(Nome);
        }
    }
}
