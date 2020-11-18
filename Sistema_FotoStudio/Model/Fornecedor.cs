using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Fornecedor : Pessoa
    {
        public String tipo_fornecedor { get; set; }
        public String CNPJ { get; set; }
        public String RazaoSocial { get; set; }
        public String NomeFantasia { get; set; }



        public Fornecedor() : base()
        {

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Fornecedor fornecedor, bool alterar)
        {
            object resultado = null;

              if (fornecedor.tipo_fornecedor.Equals("2"))
              {
                  string scalar = "Select dbo.validar_cnpj('" + fornecedor.CNPJ + "')";
                  acessoDados.LimparParametros();

                  resultado = acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar);
              }

     
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


            acessoDados.AdicionarParametros("@Tipo_Pessoa", "3");
            acessoDados.AdicionarParametros("@CPF_Pessoa", fornecedor.CPF);
            acessoDados.AdicionarParametros("@Nome", fornecedor.Nome);
            acessoDados.AdicionarParametros("@Sobrenome", null);
            acessoDados.AdicionarParametros("@Data_Nasc", null);
            acessoDados.AdicionarParametros("@RG", null);
            acessoDados.AdicionarParametros("@Situacao", 0);
            acessoDados.AdicionarParametros("@Sexo", null);
            acessoDados.AdicionarParametros("@Logradouro", fornecedor.Logradouro);
            acessoDados.AdicionarParametros("@Numero", fornecedor.Numero);
            acessoDados.AdicionarParametros("@Bairro", fornecedor.Bairro);
            acessoDados.AdicionarParametros("@Cidade", fornecedor.Cidade);
            acessoDados.AdicionarParametros("@CEP", fornecedor.CEP);
            acessoDados.AdicionarParametros("@UF", fornecedor.UF);
            acessoDados.AdicionarParametros("@Email", fornecedor.email);
            acessoDados.AdicionarParametros("@Telefone", fornecedor.telefone);
            acessoDados.AdicionarParametros("@Celular", fornecedor.celular);
            acessoDados.AdicionarParametros("@Tipo_Fornecedor", Convert.ToInt32(fornecedor.tipo_fornecedor));

            if (fornecedor.tipo_fornecedor.Equals("2"))
            {
                
                acessoDados.AdicionarParametros("@CNPJ", fornecedor.CNPJ);
                acessoDados.AdicionarParametros("@RazaoSocial", fornecedor.RazaoSocial);
                acessoDados.AdicionarParametros("@NomeFantasia", fornecedor.NomeFantasia);
            }
           
      

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

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@RazaoSocial", RazaoSocial);

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

        public Fornecedor PesquisarPorCodigo(String Codigo)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 5);
            acessoDados.AdicionarParametros("@Codigo", Codigo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            return PassarParametros(new Fornecedor(), dataTable);
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

        public DataTable PesquisarPorCPFTabela(string CPF)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            return dataTable;

        }

        public DataTable PesquisarPorCNPJTabela(string CNPJ)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CNPJ", CNPJ);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_fornecedor");

            return dataTable;

        }



        public Fornecedor PassarParametros(Fornecedor fornecedor, DataTable dataTable)
        {
            fornecedor.CNPJ = Convert.ToString(dataTable.Rows[0]["CNPJ"]);
            fornecedor.RazaoSocial = Convert.ToString(dataTable.Rows[0]["RazaoSocial"]);
            fornecedor.NomeFantasia = Convert.ToString(dataTable.Rows[0]["NomeFantasia"]);
            fornecedor.CPF = Convert.ToString(dataTable.Rows[0]["CPF_Pessoa"]);
            fornecedor.Nome = Convert.ToString(dataTable.Rows[0]["Nome"]);
            fornecedor.Logradouro = Convert.ToString(dataTable.Rows[0]["Logradouro"]);
            fornecedor.Numero = Convert.ToInt32(dataTable.Rows[0]["Numero"]);
            fornecedor.Bairro = Convert.ToString(dataTable.Rows[0]["Bairro"]);
            fornecedor.Cidade = Convert.ToString(dataTable.Rows[0]["Cidade"]);
            fornecedor.CEP = Convert.ToString(dataTable.Rows[0]["CEP"]);
            fornecedor.UF = Convert.ToString(dataTable.Rows[0]["UF"]);
            fornecedor.tipo_fornecedor = Convert.ToString(dataTable.Rows[0]["tipo"]);
            fornecedor.Situação = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);
            fornecedor.email = Convert.ToString(dataTable.Rows[0]["Email"]);
            fornecedor.telefone = Convert.ToString(dataTable.Rows[0]["Telefone"]);
            fornecedor.celular = Convert.ToString(dataTable.Rows[1]["Telefone"]);
           

            return fornecedor;
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
