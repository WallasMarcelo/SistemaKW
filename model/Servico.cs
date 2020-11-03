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

        public int Cod_Servico { get; set; }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int InserirServicos(Servico servico)
        {
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Valor", servico.Valor);
            acessoDados.AdicionarParametros("@Tipo", servico.Tipo);
            acessoDados.AdicionarParametros("@Descricao", servico.Descricao);
            acessoDados.AdicionarParametros("@Situacao", servico.Situacao);

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

        public void InativarServico(Servico servico)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Cod_Servico", servico.Cod_Servico);

            acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_servico");
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



    }
}
