using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Funcionario : Pessoa
    {
        public Funcionario() : base()
        {

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Funcionario funcionario, bool alterar)
        {
            string scalar = "Select dbo.fc_validar_cpf('" + funcionario.CPF + "')";
            acessoDados.LimparParametros();

            Object resultado = acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar);

            if (alterar)
            {
                if (!resultado.ToString().Equals("0"))
                    return 0;

                acessoDados.AdicionarParametros("@Funcao", 2);//alterar
            }
            else
            {
                if (!resultado.ToString().Equals("1"))
                    return 0;

                acessoDados.AdicionarParametros("@Funcao", 1);//cadastrar
            }


            acessoDados.AdicionarParametros("@Tipo_Pessoa", "2");
            acessoDados.AdicionarParametros("@CPF_Pessoa", funcionario.CPF);
            acessoDados.AdicionarParametros("@Nome", funcionario.Nome);
            acessoDados.AdicionarParametros("@Sobrenome", funcionario.Sobrenome);
            acessoDados.AdicionarParametros("@Data_Nasc", funcionario.Data_Nasc);
            acessoDados.AdicionarParametros("@Sexo", funcionario.Sexo);
            acessoDados.AdicionarParametros("@RG", funcionario.RG);
            acessoDados.AdicionarParametros("@Situacao", funcionario.Situação);
            acessoDados.AdicionarParametros("@Logradouro", funcionario.Logradouro);
            acessoDados.AdicionarParametros("@Numero", funcionario.Numero);
            acessoDados.AdicionarParametros("@Bairro", funcionario.Bairro);
            acessoDados.AdicionarParametros("@Cidade", funcionario.Cidade);
            acessoDados.AdicionarParametros("@CEP", funcionario.CEP);
            acessoDados.AdicionarParametros("@UF", funcionario.UF);
            acessoDados.AdicionarParametros("@Email", funcionario.email);
            acessoDados.AdicionarParametros("@Telefone", funcionario.telefone);
            acessoDados.AdicionarParametros("@Celular", funcionario.celular);
            acessoDados.AdicionarParametros("@Tipo_Fornecedor", null);
            acessoDados.AdicionarParametros("@CNPJ", null);
            acessoDados.AdicionarParametros("@RazaoSocial", null);
            acessoDados.AdicionarParametros("@NomeFantasia", null);
          

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Cliente_Funcionario_Fornecedor");
   
        }


        public DataTable PesquisarPorNome(string Nome)
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome", Nome);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_funcionario");

            return dataTable;

        }

        public DataTable PesquisarPorCPFTabela(string CPF)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_funcionario");

            return dataTable;

        }

        public Funcionario PesquisarPorCodigo(String Codigo)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Codigo", Codigo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_funcionario");

            return PassarValor(new Funcionario(), dataTable);
        }

        public Funcionario PesquisarPorCPF(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_funcionario");

            return PassarValor(new Funcionario(), dataTable);
        }


        public Funcionario PassarValor(Funcionario funcionario, DataTable dataTable)
        {
            funcionario.CPF = Convert.ToString(dataTable.Rows[0]["CPF"]);
            funcionario.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
            funcionario.Sobrenome = Convert.ToString(dataTable.Rows[0]["Sobrenome"]);
            funcionario.Data_Nasc = Convert.ToDateTime(dataTable.Rows[0]["Data Nascimento"]);
            funcionario.RG = Convert.ToString(dataTable.Rows[0]["RG"]);
            funcionario.Sexo = Convert.ToString(dataTable.Rows[0]["Sexo"]);
            funcionario.CEP = Convert.ToString(dataTable.Rows[0]["CEP"]);
            funcionario.Logradouro = Convert.ToString(dataTable.Rows[0]["Logradouro"]);
            funcionario.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"]);
            funcionario.Bairro = Convert.ToString(dataTable.Rows[0]["Bairro"]);
            funcionario.Cidade = Convert.ToString(dataTable.Rows[0]["Cidade"]);
            funcionario.UF = Convert.ToString(dataTable.Rows[0]["UF"]);
            funcionario.email = Convert.ToString(dataTable.Rows[0]["Email"]);
            funcionario.telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);
            funcionario.celular = Convert.ToString(dataTable.Rows[1]["Telefone"]);
            //funcionario.Situação = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);

            return funcionario;
        }




    }
}
