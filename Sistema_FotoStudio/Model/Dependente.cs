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

        public String nome_dependente { get; set; }

        public String data_nascimento { get; set; }

        public int cod_cliente { get; set; }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int InserirDependente(Dependente dependente)
        {
            acessoDados.AdicionarParametros("@Funcao", "1");
            acessoDados.AdicionarParametros("@Nome", dependente.nome_dependente);
            acessoDados.AdicionarParametros("@Data_nascimento", dependente.data_nascimento);
            acessoDados.AdicionarParametros("@Cod_Cliente", dependente.cod_cliente);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_dependente");
        }

        public void AlterarDependente(Dependente dependente)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome", dependente.nome_dependente);
            acessoDados.AdicionarParametros("@Data_nascimento", dependente.data_nascimento);
            acessoDados.AdicionarParametros("@Cod_Cliente", dependente.cod_cliente);

            acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_dependente");

        }

        public Dependente PesquisarPorCPFCliente(int CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF_Cliente", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            Dependente dependente = new Dependente();

            dependente.cod_cliente = Convert.ToInt32(dataTable.Rows[0]["Tipo"]);
            dependente.nome_dependente = Convert.ToString(dataTable.Rows[0]["Valor"]);
            dependente.data_nascimento = Convert.ToString(dataTable.Rows[0]["Descricao"]);
            
            return dependente;
        }

        public DataTable PesquisarPorDescricao(Dependente dependente)
        {
            List<Dependente> ListaDependente = new List<Dependente>();


            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Nome_cliente", dependente.nome_dependente);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_dependente");

            return dataTable;
        }

        public DataTable TrazerDependente(String date)
        {
            string consulta = "Select * from dbo.fc_aniversario('" + date + "')";
            acessoDados.LimparParametros();

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, consulta);

            return dataTable;
        }

    }
}
