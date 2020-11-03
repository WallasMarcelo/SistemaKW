using Sistema_FotoStudio.Banco_de_dados;
using Sistema_FotoStudio.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio
{
    public class Cliente
    {
        public Cliente()
        {
            ClienteController controller = new ClienteController();
        

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Cliente cliente)
        {
            /*string scalar = "Select dbo.buscarIDPessoa('" + cliente.CPF + "')";
              acessoDados.LimparParametros();

              object CPF = acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar);

              if (!CPF.Equals(""))
                  acessoDados.AdicionarParametros("@Funcao", 1);//alterar
              else
                  acessoDados.AdicionarParametros("@Funcao", 2);//cadastrar*/

            acessoDados.AdicionarParametros("@Tipo_Pessa", "1");
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
            acessoDados.AdicionarParametros("@Estado", cliente.UF);
            acessoDados.AdicionarParametros("@Telefone", cliente.telefone);
            acessoDados.AdicionarParametros("@Tipo_Telefone", cliente.tipo_telefone);
            acessoDados.AdicionarParametros("@Tipo_Fornecedor", null);
            acessoDados.AdicionarParametros("@CNPJ", null);
            acessoDados.AdicionarParametros("@RazaoSocial", null);
            acessoDados.AdicionarParametros("@NomeFantasia", null);
            acessoDados.AdicionarParametros("@Situacao", cliente.Situação);
       
            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Cliente_Funcionario_Fornecedor");
        }

        public DataTable PesquisarPorNome(string Nome)
        {
            List<Funcionario> listaFuncionario = new List<Funcionario>();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome", Nome);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            return dataTable;

        }

        public Cliente Pesquisarcliente(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_cliente");

            Cliente cliente = new Cliente();

            cliente.CPF = Convert.ToString(dataTable.Rows[0]["CPF_Pessoa"]);
            cliente.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
            cliente.Sobrenome = Convert.ToString(dataTable.Rows[0]["Sobrenome"]);
            cliente.Data_Nasc = Convert.ToDateTime(dataTable.Rows[0]["Data_Nasc"]);
            cliente.RG = Convert.ToString(dataTable.Rows[0]["RG"]);
            cliente.Sexo = Convert.ToString(dataTable.Rows[0]["Sexo"]);
            cliente.Logradouro = Convert.ToString(dataTable.Rows[0]["Logradouro"]);
            cliente.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"]);
            cliente.Bairro = Convert.ToString(dataTable.Rows[0]["Bairro"]);
            cliente.Cidade = Convert.ToString(dataTable.Rows[0]["Cidade"]);
            cliente.UF = Convert.ToString(dataTable.Rows[0]["Estado"]);
            cliente.telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);
            cliente.tipo_telefone = Convert.ToInt32(dataTable.Rows[0]["Tipo_Telefone"]);
            cliente.Situação = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);

            return cliente;
        }

    }
}
