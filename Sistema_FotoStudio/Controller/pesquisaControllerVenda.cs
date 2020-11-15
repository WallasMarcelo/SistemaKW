using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class pesquisaControllerVenda
    {
        public DataTable pesquisaPorCodigo(String Codigo)
        {
            Vendas vendas = new Vendas();
            return vendas.PesquisarPorCodigoTabela(Codigo);

        }

        public DataTable pesquisaPorCPF(String CPF)
        {
            Vendas vendas = new Vendas();
            return vendas.PesquisarVendaPorCPF(CPF);
        }

        public DataTable pesquisaPorNome(String Nome)
        {
            Vendas vendas = new Vendas();
            return vendas.PesquisarVendaPorCPF(Nome);
        }

        public DataTable pesquisaTodos()
        {
            Vendas vendas = new Vendas();
            return vendas.PesquisarPorTodos();
        }
    }
}
