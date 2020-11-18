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
    class FuncionarioController 
    {
        public int cadastrar(String CPF, String RG, String Sexo, String Nome, String Sobrenome, DateTime Data_Nas,
           String Logradouro, int Numero, String Bairro, String UF, String Cidade, String CEP, String Email,
                                                                    String Telefone, String Celular, bool alterar)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.CPF = CPF;
            funcionario.RG = RG;
            funcionario.Sexo = Sexo;
            funcionario.Nome = Nome;
            funcionario.Sobrenome = Sobrenome;
            funcionario.Data_Nasc = Data_Nas;
            funcionario.Logradouro = Logradouro;
            funcionario.Numero = Numero;
            funcionario.Bairro = Bairro;
            funcionario.UF = UF;
            funcionario.Cidade = Cidade;
            funcionario.CEP = CEP;
            funcionario.email = Email;
            funcionario.telefone = Telefone;
            funcionario.celular = Celular;

            return funcionario.Inserir(funcionario, alterar);

        }

        public Funcionario PesquisarPorCodigo(String Codigo)
        {
            Funcionario funcionario = new Funcionario();
            return funcionario.PesquisarPorCodigo(Codigo);
        }

        public Funcionario PesquisarPorCPF(String CPF)
        {
            Funcionario funcionario = new Funcionario();
            return funcionario.PesquisarPorCPF(CPF);
        }

        public void PesquisarPorNome(String Nome, frmCadastroFuncionario Cadastro, frmPrincipal principal)
        {
            Funcionario funcionario = new Funcionario();
            DataTable tabela = funcionario.PesquisarPorNome(Nome);//Resultados da pesquisa

            if (tabela.Rows.Count == 1)//Se a tabrla conter apenas um registro, não exibir a tabela
            {
                PassarCPF(tabela.Rows[0]["CPF"].ToString(), Cadastro);//Chamar o método PassarCPF 
                return;
            }

            pesquisaResultadoFuncionario pesquisa = new pesquisaResultadoFuncionario(tabela, Cadastro);//Criar objeto PesquisaResultado
            pesquisa.Show();//Mostrar o objeto
        }

        public void PassarCPF(String CPF, frmCadastroFuncionario cadastrofuncionario)
        {
            Funcionario funcionario = PesquisarPorCPF(CPF);//Realizar pesquisa pela cpf da linha escolhida do DAtaGrd
            cadastrofuncionario.PassarValores(funcionario);//Cahmar método passarValores do Forms

        }

        public int Inativar(String CPF)
        {
            Funcionario funcionario = new Funcionario();
            return funcionario.Inativar(CPF);
            ;
        }

    }
}
