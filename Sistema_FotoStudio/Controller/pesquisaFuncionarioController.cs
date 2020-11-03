using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    class pesquisaFuncionarioController
    {
        public DataTable pesquisaPorCPF(String CPF)
        {
            Funcionario funcionario = new Funcionario();
            return funcionario.PesquisarPorCPFTabela(CPF);

        }

        public DataTable pesquisaPorNome(String Nome)
        {
            Funcionario funcionario = new Funcionario();
            return funcionario.PesquisarPorNome(Nome);
        }
    }
}
