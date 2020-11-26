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

        public int CadastrarDependente(string cod_cliente, string nome, String dataNascimento, string cod_dependente)
        {
            Dependente dependente = new Dependente();

            dependente.cod_cliente = cod_cliente;
            dependente.nome_dependente = nome;
            dependente.data_nascimento = dataNascimento;
            dependente.cod_dependente = cod_dependente;

            return dependente.InserirDependente(dependente);

        }


        public DataTable TrazerAniversariantes(String date)
        {
            Dependente dependente = new Dependente();
            return dependente.TrazerDependente(date);

        }


        public DataTable pegaCliente(string cpf)
        {
            Dependente dependente = new Dependente();
            return dependente.pegaCliente(cpf);
        }

        public Dependente PesquisarPorCodigo(string cod)
        {
            Dependente dependente = new Dependente();
            return dependente.PesquisarPorCodDependente(cod);
        }

        public DataTable PesquisarPorCPF(String CPF)
        {
            Dependente dependente = new Dependente();
            return dependente.PesquisarPorCPFTabela(CPF);
        }

        public DataTable PesquisarPorNome(String Nome)
        {
            Dependente dependente = new Dependente();
            return dependente.PesquisarPorNome(Nome);
        }

        public DataTable PesquisaTodosDependente()
        {
            Dependente dependente = new Dependente();
            return dependente.PesquisaTodosDependentes();
        }
    }
}