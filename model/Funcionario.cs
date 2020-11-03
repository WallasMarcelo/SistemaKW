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

        public int Inserir(Funcionario funcionario)
        {
          /*string scalar = "Select dbo.buscarIDPessoa('" + funcionario.CPF + "')";
            acessoDados.LimparParametros();

            object CPF = acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar);

            if (!CPF.Equals(""))
                acessoDados.AdicionarParametros("@Funcao", 1);//alterar
            else
                acessoDados.AdicionarParametros("@Funcao", 2);//cadastrar*/

            acessoDados.AdicionarParametros("@Tipo_Pessa", "2");
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
            acessoDados.AdicionarParametros("@Estado", funcionario.UF);
            acessoDados.AdicionarParametros("@Telefone", funcionario.telefone);
            acessoDados.AdicionarParametros("@Tipo_Telefone", funcionario.tipo_telefone);
            acessoDados.AdicionarParametros("@Tipo_Fornecedor", null);
            acessoDados.AdicionarParametros("@CNPJ", null);
            acessoDados.AdicionarParametros("@RazaoSocial", null);
            acessoDados.AdicionarParametros("@NomeFantasia", null);
            acessoDados.AdicionarParametros("@Situacao", funcionario.Situação);
            // acessoDados.AdicionarParametros("@Usuario", Usuario);
            // acessoDados.AdicionarParametros("@Senha", Senha);

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


        public Funcionario PesquisarPorCPF(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_funcionario");

            Funcionario funcionario = new Funcionario();

            funcionario.CPF = Convert.ToString(dataTable.Rows[0]["CPF_Pessoa"]);
            funcionario.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
            funcionario.Sobrenome = Convert.ToString(dataTable.Rows[0]["Sobrenome"]);
            funcionario.Data_Nasc = Convert.ToDateTime(dataTable.Rows[0]["Data_Nasc"]);
            funcionario.RG = Convert.ToString(dataTable.Rows[0]["RG"]);
            funcionario.Sexo = Convert.ToString(dataTable.Rows[0]["Sexo"]);
            funcionario.Logradouro= Convert.ToString(dataTable.Rows[0]["Logradouro"]);
            funcionario.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"]);
            funcionario.Bairro = Convert.ToString(dataTable.Rows[0]["Bairro"]);
            funcionario.Cidade = Convert.ToString(dataTable.Rows[0]["Cidade"]);
            funcionario.UF = Convert.ToString(dataTable.Rows[0]["Estado"]);
            funcionario.telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);
            funcionario.tipo_telefone = Convert.ToInt32(dataTable.Rows[0]["Tipo_Telefone"]);
            funcionario.Situação = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);

            return funcionario;
        }


     

    }
}
