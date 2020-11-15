using Sistema_FotoStudio.Model;
using Sistema_FotoStudio.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class VendaController
    {
        public String buscarClinte(String CPF)
        {   
            Vendas vendas = new Vendas();

            return  vendas.PequisarCliente(CPF);
        }

        public String buscarFuncionario(String Codigo)
        {
            Vendas vendas = new Vendas();

            return vendas.PequisarFuncionario(Codigo);
        }

        public String buscarProduto(String codigo)
        {
            Vendas vendas = new Vendas();

            return vendas.PequisarProduto(codigo);

        }

        public DataTable buscarServico(String codigo)
        {
            Vendas vendas = new Vendas();

            return vendas.PequisarServiço(codigo);
        }


        public int Salvar(String CPF, String CodigoFuncionario, DateTime DataVenda, DataTable itensVenda, String CodVenda)
        {
            Vendas vendas = new Vendas();
            vendas.CPF = CPF;
            vendas.Cod_funcionario = Convert.ToInt32(CodigoFuncionario);
            vendas.Data_venda = DataVenda;
            vendas.ItensVendas = itensVenda;
            vendas.Cod_venda = CodVenda;

            return vendas.InserirItemVenda(vendas);

        }

        public Vendas pesquiarPorCodigo(int Codigo)
        {
            Vendas venda = new Vendas();
            return venda.PesquisarPorCodigo(Codigo);
        }

        public void pesquiarPorCPF(String CPF, frmVendas Cadastro, frmPrincipal principal)
        {
            Vendas venda = new Vendas();
            DataTable tabela = venda.PesquisarVendaPorCPF(CPF);

            if (tabela.Rows.Count == 1)//Se a tabrla conter apenas um registro, não exibir a tabela
            {
                PassarCodigo(tabela.Rows[0]["Código"].ToString(), Cadastro);//Chamar o método PassarCPF 
                return;
            }

            pesquisaResultadoVendas pesquisa = new pesquisaResultadoVendas(tabela, Cadastro);//Criar objeto PesquisaResultado
            pesquisa.MdiParent = principal;
            pesquisa.Show();//Mostrar o objeto
        }

        public void pesquiarPorNome(String Nome, frmVendas Cadastro, frmPrincipal principal)
        {
            Vendas venda = new Vendas();
            DataTable tabela = venda.PesquisarPorNome(Nome);

            if (tabela.Rows.Count == 1)//Se a tabrla conter apenas um registro, não exibir a tabela
            {
                PassarCodigo(tabela.Rows[0]["Código"].ToString(), Cadastro);//Chamar o método PassarCPF 
                return;
            }

            pesquisaResultadoVendas pesquisa = new pesquisaResultadoVendas(tabela, Cadastro);//Criar objeto PesquisaResultado
            pesquisa.MdiParent = principal;
            pesquisa.Show();//Mostrar o objeto
        }

        public DataTable pesquisarItemVenda(int CodigoVenda)
        {
            Vendas vendas = new Vendas();
            return vendas.PesquisarItemVenda(CodigoVenda);

        }

        public void PassarCodigo(String Codigo, frmVendas cadastroVenda)
        {
            Vendas vendas = pesquiarPorCodigo(Convert.ToInt32(Codigo));//Realizar pesquisa pela cpf da linha escolhida do DAtaGrd
            cadastroVenda.PassarValores(vendas);//Cahmar método passarValores do Forms

        }


    }
}
