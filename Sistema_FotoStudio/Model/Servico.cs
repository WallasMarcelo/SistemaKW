using System;
using System.Data;
using Sistema_FotoStudio.Banco_de_dados;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Servico
    {
        public decimal Valor { get; set; }
        public String Tipo { get; set; }
        public String Descricao { get; set; }

        public int Situacao { get; set; }

        public string Cod_Servico { get; set; }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int InserirServicos(Servico servico)
        {

            if(servico.Cod_Servico.Equals(""))
                acessoDados.AdicionarParametros("@Funcao", 1);
            else
                acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@COD_SERVICO", servico.Cod_Servico);
            acessoDados.AdicionarParametros("@VALOR", servico.Valor);
            acessoDados.AdicionarParametros("@TIPO", servico.Tipo);
            acessoDados.AdicionarParametros("@DESCRICAO", servico.Descricao);
            acessoDados.AdicionarParametros("@SITUACAO", 1);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_servico");
        }


        public void alterarServico(Servico servico)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Cod_Servico",servico.Cod_Servico);
            acessoDados.AdicionarParametros("@Valor", servico.Valor);
            acessoDados.AdicionarParametros("@Tipo", servico.Tipo);
            acessoDados.AdicionarParametros("@Descricao", servico.Descricao);
            acessoDados.AdicionarParametros("@Situacao", servico.Situacao);

            acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_servico");

        }

        public int InativarServico(int cod)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Cod_Servico", cod);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_servico");
        }


        public Servico PesquisarPorCodigo(int COD)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Servico", COD);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            Servico servico = new Servico();

            
            servico.Tipo = Convert.ToString(dataTable.Rows[0]["Tipo"]);
            servico.Valor = Convert.ToDecimal(dataTable.Rows[0]["Valor"]);
            servico.Descricao = Convert.ToString(dataTable.Rows[0]["Descricao"]);
            servico.Situacao = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);
            
            return servico;
        }



        public DataTable PesquisarPorDescricao(Servico servico)
        {
            List<Servico> Listaservico = new List<Servico>();


            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Tipo", servico.Tipo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            return dataTable;
        }

        public DataTable PesquisarTodos()
        {
         
            acessoDados.AdicionarParametros("@Funcao", 3);
            

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            return dataTable;
        }

        public DataTable PesquisarTodosRelatorio()
        {

            acessoDados.AdicionarParametros("@Funcao", 4);


            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            return dataTable;
        }

        public DataTable PesquisaCod(string cod)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Servico", cod);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            return dataTable;

        }

        public DataTable PesquisaServico(string servico)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Tipo", servico);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            return dataTable;

        }

        public DataTable PesquisarTodosServico()
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_servico");

            return dataTable;

        }


    }
}
