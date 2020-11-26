using System;
using Sistema_FotoStudio.Banco_de_dados;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Dependente
    {
        public string nomePais { get; set; }
        public String nome_dependente { get; set; }

        public String data_nascimento { get; set; }

        public string cod_cliente { get; set; }

        public string cod_dependente { get; set; }

        public string cpf_pais { get; set; }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int InserirDependente(Dependente dependente)
        {

            if (dependente.cod_dependente.Equals(""))
                acessoDados.AdicionarParametros("@Funcao", 1);
            else
                acessoDados.AdicionarParametros("@Funcao", 2);
            
            acessoDados.AdicionarParametros("@Nome", dependente.nome_dependente);
            acessoDados.AdicionarParametros("@Data_nascimento", dependente.data_nascimento);
            acessoDados.AdicionarParametros("@Cod_Cliente", dependente.cod_cliente);
            acessoDados.AdicionarParametros("@Cod_dependente", dependente.cod_dependente);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_dependente");
        }

       

       

        public DataTable PesquisarPorDescricao(Dependente dependente)
        {
            List<Dependente> ListaDependente = new List<Dependente>();


            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome_cliente", dependente.nome_dependente);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            return dataTable;
        }

        public Dependente PesquisarPorCodDependente(string cod)
        {


            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Cod_Dependente", cod);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            return PassarValores(new Dependente(), dataTable);
            
        }

        public Dependente PassarValores(Dependente dependente, DataTable dataTable)
        {
            dependente.cod_dependente = Convert.ToString(dataTable.Rows[0]["Codigo"]);
            dependente.nomePais = Convert.ToString(dataTable.Rows[0]["Pais"]);
            dependente.nome_dependente = Convert.ToString(dataTable.Rows[0]["Nome"]);
            dependente.data_nascimento = Convert.ToString(dataTable.Rows[0]["Data Nascimento"]);
            dependente.cpf_pais = Convert.ToString(dataTable.Rows[0]["CPF_Pais"]); 


            return dependente;
        }

        public DataTable TrazerDependente(String date)
        {
            string consulta = "Select * from dbo.fc_aniversario('" + date + "')";
            acessoDados.LimparParametros();

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, consulta);

            return dataTable;
        }

        public DataTable pegaCliente(string cpf)
        {
            string consulta = "Select * from dbo.fc_busca_cliente_cpf('" + cpf + "')";
            acessoDados.LimparParametros();

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, consulta);

            return dataTable;
        }

        public DataTable PesquisarPorNome(string Nome)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome_cliente", Nome);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            return dataTable;

        }

        public DataTable PesquisarPorCPFTabela(string CPF)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF_Cliente", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            return dataTable;

        }

        public DataTable PesquisaTodosDependentes()
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 4);
            

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            return dataTable;

        }


    }
}
