using Sistema_FotoStudio.Banco_de_dados;
using Sistema_FotoStudio.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Cliente : Pessoa
    {
        private String Codigo;
        public Cliente() : base()
        {
            ClienteController controller = new ClienteController();
        

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Cliente cliente, bool alterar)
        {
             string scalar = "Select dbo.fc_validar_cpf('" + cliente.CPF + "')";
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
               

            acessoDados.AdicionarParametros("@Tipo_Pessoa", "1");
            acessoDados.AdicionarParametros("@CPF_Pessoa", cliente.CPF);
            acessoDados.AdicionarParametros("@Nome", cliente.Nome);
            acessoDados.AdicionarParametros("@Sobrenome", cliente.Sobrenome);
            acessoDados.AdicionarParametros("@Data_Nasc", cliente.Data_Nasc);
            acessoDados.AdicionarParametros("@Sexo", cliente.Sexo);
            acessoDados.AdicionarParametros("@RG", cliente.RG);
            acessoDados.AdicionarParametros("@Situacao", cliente.Situação);
            acessoDados.AdicionarParametros("@Logradouro", cliente.Logradouro);
            acessoDados.AdicionarParametros("@Numero", cliente.Numero);
            acessoDados.AdicionarParametros("@Bairro", cliente.Bairro);
            acessoDados.AdicionarParametros("@Cidade", cliente.Cidade);
            acessoDados.AdicionarParametros("@CEP", cliente.CEP);
            acessoDados.AdicionarParametros("@UF", cliente.UF);
            acessoDados.AdicionarParametros("@Email", cliente.email);
            acessoDados.AdicionarParametros("@Telefone", cliente.telefone);
            acessoDados.AdicionarParametros("@Celular", cliente.celular);
            acessoDados.AdicionarParametros("@Tipo_Fornecedor", null);
            acessoDados.AdicionarParametros("@CNPJ", null);
            acessoDados.AdicionarParametros("@RazaoSocial", null);
            acessoDados.AdicionarParametros("@NomeFantasia", null);
       
            int result = acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Cliente_Funcionario_Fornecedor");

            return result;
        }

        public DataTable PesquisarPorNome(string Nome)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome", Nome);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            return dataTable;

        }

        public DataTable PesquisarTodos()
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 4);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            return dataTable;

        }

        public DataTable PesquisarPorCPFTabela(string CPF)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            return dataTable;

        }


        public Cliente PesquisarPorCPF(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            return PassarValores(new Cliente(), dataTable);
        }

        public Cliente PesquisarPorCodigo(String Codigo)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Codigo", Codigo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            return PassarValores(new Cliente(), dataTable);
        }

        public Cliente PassarValores(Cliente cliente, DataTable dataTable)
        {
            cliente.Codigo = Convert.ToString(dataTable.Rows[0]["Cod"]);
            cliente.CPF = Convert.ToString(dataTable.Rows[0]["CPF"]);
            cliente.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
            cliente.Sobrenome = Convert.ToString(dataTable.Rows[0]["Sobrenome"]);
            cliente.Data_Nasc = Convert.ToDateTime(dataTable.Rows[0]["Data Nascimento"]);
            cliente.RG = Convert.ToString(dataTable.Rows[0]["RG"]);
            cliente.Sexo = Convert.ToString(dataTable.Rows[0]["Sexo"]);
            cliente.Logradouro = Convert.ToString(dataTable.Rows[0]["Logradouro"]);
            cliente.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"]);
            cliente.Bairro = Convert.ToString(dataTable.Rows[0]["Bairro"]);
            cliente.Cidade = Convert.ToString(dataTable.Rows[0]["Cidade"]);
            cliente.UF = Convert.ToString(dataTable.Rows[0]["UF"]);
            cliente.CEP = Convert.ToString(dataTable.Rows[0]["CEP"]);
            cliente.email = Convert.ToString(dataTable.Rows[0]["Email"]);
            cliente.telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);
            cliente.celular = Convert.ToString(dataTable.Rows[1]["Telefone"]);
            // cliente.Situação = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);

            return cliente;
        }

        public int Inativar(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@CPF_Pessoa", CPF);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Cliente_Funcionario_Fornecedor");

           
        }

    }
}
