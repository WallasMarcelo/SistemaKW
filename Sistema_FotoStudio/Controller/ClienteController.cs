
using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_FotoStudio.Model;
using Sistema_FotoStudio.View;
using System.Data;

namespace Sistema_FotoStudio.Controller
{
    public class ClienteController
    {

        frmPrincipal principal;

        public int cadastrar(String CPF, String RG, String Sexo, String Nome, String Sobrenome, DateTime Data_Nas, 
            String Logradouro, int Numero, String Bairro, String UF, String Cidade, String CEP, String Email, 
                                                                    String Telefone, String Celular, bool alterar)
        {
            Cliente cliente = new Cliente();

            cliente.CPF = CPF;
            cliente.RG =  RG;
            cliente.Sexo = Sexo;
            cliente.Nome = Nome;
            cliente.Sobrenome = Sobrenome;
            cliente.Data_Nasc = Data_Nas;
            cliente.Logradouro = Logradouro;
            cliente.Numero = Numero;
            cliente.Bairro = Bairro;
            cliente.UF = UF;
            cliente.Cidade = Cidade;
            cliente.CEP = CEP;
            cliente.email = Email;
            cliente.telefone = Telefone;
            cliente.celular = Celular;

            return cliente.Inserir(cliente,alterar);

        }

        public Cliente PesquisarPorCodigo(String Codigo)
        {
            Cliente cliente = new Cliente();
            return cliente.PesquisarPorCodigo(Codigo);
        }

        public Cliente PesquisarPorCPF(String CPF)
        {
            Cliente cliente = new Cliente();
            return cliente.PesquisarPorCPF(CPF);
        }

        public void PesquisarPorNome(String Nome, frmCadastroCliente Cadastro, frmPrincipal principal)
        {
            Cliente cliente = new Cliente();
            DataTable tabela = cliente.PesquisarPorNome(Nome);//Resultados da pesquisa

            if(tabela.Rows.Count == 1)//Se a tabrla conter apenas um registro, não exibir a tabela
            {
                PassarCPF(tabela.Rows[0]["CPF"].ToString(),Cadastro);//Chamar o método PassarCPF 
                return;
            }

            PesquisaResultado pesquisa = new PesquisaResultado(tabela,Cadastro);//Criar objeto PesquisaResultado
            pesquisa.MdiParent = principal;
            pesquisa.Show();//Mostrar o objeto

        }

        public DataTable PesquisarTodos()
        {
            Cliente cliente = new Cliente();
            return cliente.PesquisarTodos();
        }

        public void PassarCPF(String CPF, frmCadastroCliente cadastroCliente)
        {
            Cliente cliente = PesquisarPorCPF(CPF);//Realizar pesquisa pela cpf da linha escolhida do DAtaGrd
            cadastroCliente.PassarValores(cliente);//Cahmar método passarValores do Forms
         
        }

        public int Inativar(String CPF)
        {
            Cliente cliente = new Cliente();
            return cliente.Inativar(CPF);
;       }

    }
}
