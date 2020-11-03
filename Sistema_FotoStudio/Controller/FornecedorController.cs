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
    public class FornecedorController
    {
        public int cadastrar(String CPF, String Nome, String CNPJ, String RazaoSocial, String NomeFantasia, String tipo,
        String Logradouro, int Numero, String Bairro, String UF, String Cidade, String CEP, String Email, String Telefone, 
                                                                                             String Celular, bool alterar)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.CPF = CPF;
            fornecedor.Nome = Nome;
            fornecedor.CNPJ = CNPJ;
            fornecedor.RazaoSocial = RazaoSocial;
            fornecedor.NomeFantasia = NomeFantasia;
            fornecedor.tipo_fornecedor = tipo;
            fornecedor.Logradouro = Logradouro;
            fornecedor.Numero = Numero;
            fornecedor.Bairro = Bairro;
            fornecedor.UF = UF;
            fornecedor.Cidade = Cidade;
            fornecedor.CEP = CEP;
            fornecedor.email = Email;
            fornecedor.telefone = Telefone;
            fornecedor.celular = Celular;

            return fornecedor.Inserir(fornecedor,alterar);

        }

        public Fornecedor PesquisarPorCodigo(String Codigo)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorCodigo(Codigo);
        }


        public Fornecedor PesquisarPorCPF(String CPF)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorCPF(CPF);
        }

        public Fornecedor PesquisarPorCNPJ(String CNPJ)
        {
            Fornecedor fornecedor = new Fornecedor();
            return fornecedor.PesquisarPorCNPJ(CNPJ);
        }

        public void PesquisarPorNome(String Nome, frmCadastroFornedor Cadastro, frmPrincipal principal)
        {
            Fornecedor cliente = new Fornecedor();
            DataTable tabela = cliente.PesquisarPorNome(Nome);//Resultados da pesquisa

            if (tabela.Rows.Count == 1)//Se a tabrla conter apenas um registro, não exibir a tabela
            {
                PassarCPF(tabela.Rows[0]["CPF"].ToString(), Cadastro);//Chamar o método PassarCPF 
                return;
            }

            PesquisaResultadoFornecedor pesquisa = new PesquisaResultadoFornecedor(tabela, Cadastro);//Criar objeto PesquisaResultado
            pesquisa.MdiParent = principal;
            pesquisa.Show();//Mostrar o objeto

        }

        public void PesquisarPorRazaoSocial(String razaoSocial, frmCadastroFornedor Cadastro, frmPrincipal principal)
        {
            Fornecedor fornecedor = new Fornecedor();
            DataTable tabela = fornecedor.PesquisarPorRazaoSocial(razaoSocial);//Resultados da pesquisa

            if(tabela.Rows.Count == 0)
            {
                Cadastro.MenssageVazio();
                return;
            }


            if (tabela.Rows.Count == 1)//Se a tabela conter apenas um registro, não exibir a tabela
            {
                PassarCPF(tabela.Rows[0]["CPF"].ToString(), Cadastro);//Chamar o método PassarCPF 
                return;
            }

            PesquisaResultadoFornecedor pesquisa = new PesquisaResultadoFornecedor(tabela, Cadastro);//Criar objeto PesquisaResultado
            pesquisa.MdiParent = principal;
            pesquisa.Show();//Mostrar o objeto
        }

        public void PassarCPF(String CPF, frmCadastroFornedor cadastroCFornecedor)
        {
            Fornecedor fornecedor = PesquisarPorCPF(CPF);//Realizar pesquisa pela cpf da linha escolhida do DAtaGrd
            cadastroCFornecedor.PassarValores(fornecedor);//Cahmar método passarValores do Forms


        }

    }
}
