using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.View
{
    public class pesquisaFornecedorController
    {
        public DataTable pesquisaPorCPF(String CPF)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorCPFTabela(CPF);

        }

        public DataTable pesquisaPorNome(String Nome)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorNome(Nome);
        }

        public DataTable pesquisaPorCNPJ(String CNPJ)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorCNPJTabela(CNPJ);

        }

        public DataTable pesquisaPorRazaoSocial(String razaoSocial)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorRazaoSocial(razaoSocial);
        }
    }
}
