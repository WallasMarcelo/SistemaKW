using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    class Fornecedor : Pessoa
    {
        public String tipo_fornecedor { get; set; }
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }
        public String NomeFantasia { get; set; }



        public Fornecedor() : base()
        {

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Fornecedor fornecedor)
        {
            /*string scalar = "Select dbo.buscarIDPessoa('" + fornecedor.CPF + "')";
              acessoDados.LimparParametros();

              object CPF = acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar);

              if (!CPF.Equals(""))
                  acessoDados.AdicionarParametros("@Funcao", 1);//alterar
              else
                  acessoDados.AdicionarParametros("@Funcao", 2);//cadastrar*/

            acessoDados.AdicionarParametros("@Tipo_Pessa", "3");
            acessoDados.AdicionarParametros("@CPF_Pessoa", fornecedor.CPF);
            acessoDados.AdicionarParametros("@Nome", fornecedor.Nome);
            acessoDados.AdicionarParametros("@Sobrenome", fornecedor.Sobrenome);
            acessoDados.AdicionarParametros("@Data_Nasc", fornecedor.Data_Nasc);
            acessoDados.AdicionarParametros("@Sexo", fornecedor.Sexo);
            acessoDados.AdicionarParametros("@RG", fornecedor.RG);
            acessoDados.AdicionarParametros("@Situacao", fornecedor.Situação);
            acessoDados.AdicionarParametros("@Logradouro", fornecedor.Logradouro);
            acessoDados.AdicionarParametros("@Numero", fornecedor.Numero);
            acessoDados.AdicionarParametros("@Bairro", fornecedor.Bairro);
            acessoDados.AdicionarParametros("@Cidade", fornecedor.Cidade);
            acessoDados.AdicionarParametros("@Estado", fornecedor.UF);
            acessoDados.AdicionarParametros("@Telefone", fornecedor.telefone);
            acessoDados.AdicionarParametros("@Tipo_Telefone", fornecedor.tipo_telefone);
            acessoDados.AdicionarParametros("@Tipo_Fornecedor", fornecedor.tipo_fornecedor);
            acessoDados.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
            acessoDados.AdicionarParametros("@RazaoSocial", fornecedor.RazaoSocial);
            acessoDados.AdicionarParametros("@NomeFantasia", fornecedor.NomeFantasia);
            acessoDados.AdicionarParametros("@Situacao", fornecedor.Situação);
      

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Cliente_Funcionario_Fornecedor");
        }


        public Fornecedor PesquisarPorCNPJ(String CNPJ)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CNPJ", CNPJ);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            Fornecedor fornecedor = PassarParametros(new Fornecedor(), dataTable);

            return fornecedor;
        }



        public DataTable PesquisarPorRazaoSocial(string RazaoSocial)
        {
            List<Fornecedor> listafornecedor = new List<Fornecedor>();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome", RazaoSocial);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            return dataTable;

        }

        public Fornecedor PesquisarPorCPF(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            Fornecedor fornecedor = PassarParametros(new Fornecedor(), dataTable);

            return fornecedor;
        }



        public DataTable PesquisarPorNome(string Nome)
        {
            List<Fornecedor> listafornecedor = new List<Fornecedor>();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 4);
            acessoDados.AdicionarParametros("@Nome", Nome);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            return dataTable;

        }



        public Fornecedor PassarParametros(Fornecedor fornecedor, DataTable dataTable)
        {
            fornecedor.CPF = Convert.ToString(dataTable.Rows[0]["CPF_Pessoa"]);
            fornecedor.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
            fornecedor.Sobrenome = Convert.ToString(dataTable.Rows[0]["Sobrenome"]);
            fornecedor.Data_Nasc = Convert.ToDateTime(dataTable.Rows[0]["Data_Nasc"]);
            fornecedor.RG = Convert.ToString(dataTable.Rows[0]["RG"]);
            fornecedor.Sexo = Convert.ToString(dataTable.Rows[0]["Sexo"]);
            fornecedor.Logradouro = Convert.ToString(dataTable.Rows[0]["Logradouro"]);
            fornecedor.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"]);
            fornecedor.Bairro = Convert.ToString(dataTable.Rows[0]["Bairro"]);
            fornecedor.Cidade = Convert.ToString(dataTable.Rows[0]["Cidade"]);
            fornecedor.UF = Convert.ToString(dataTable.Rows[0]["Estado"]);
            fornecedor.telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);
            fornecedor.tipo_telefone = Convert.ToInt32(dataTable.Rows[0]["Tipo_Telefone"]);
            fornecedor.Situação = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);

            return fornecedor;
        }

    }
}
