using System;
using Sistema_FotoStudio.Banco_de_dados;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Produto
    {
        public String descricao { get; set; }

        public int quantidade { get; set; }

        public String marca { get; set; }

        public String lote { get; set; }

        public int situacao { get; set; }

        public int cod_fornecedor { get; set; }

        public String cod_produto { get; set; }

        public string nome_fornecedor { get; set; }
      



        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public int ManterProduto(Produto produto)
        {
            if (produto.cod_produto.Equals(""))
                acessoDados.AdicionarParametros("@Funcao", "1");
            else
                acessoDados.AdicionarParametros("@Funcao", "2");
            acessoDados.AdicionarParametros("@Cod_Produto", produto.cod_produto);
            acessoDados.AdicionarParametros("@Descricao", produto.descricao);
            acessoDados.AdicionarParametros("@Quantidade", produto.quantidade);
            acessoDados.AdicionarParametros("@Marca", produto.marca);
            acessoDados.AdicionarParametros("@Lote", produto.lote);
            acessoDados.AdicionarParametros("@Situacao", produto.situacao);
            acessoDados.AdicionarParametros("@Cod_Fornecedor", produto.cod_fornecedor);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_produto");
        }

       

        public int inativarProduto(int cod)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Cod_produto", cod);

           return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_produto");
        }

        public Produto PesquisarPorCodigo(string COD)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Produto", COD);
            

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_produto");

            Produto produto = new Produto();

            produto.cod_produto = Convert.ToString(dataTable.Rows[0]["Codigo"]);
            produto.descricao = Convert.ToString(dataTable.Rows[0]["Descricao"]);
            produto.quantidade = Convert.ToInt32(dataTable.Rows[0]["Quantidade"]);
            produto.marca = Convert.ToString(dataTable.Rows[0]["Marca"]);
            produto.lote = Convert.ToString(dataTable.Rows[0]["Lote"]);
            produto.situacao = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);
            produto.nome_fornecedor = Convert.ToString(dataTable.Rows[0]["NomeFantasia"]);

            return produto;
        }

       

        public DataTable buscaFornecedorCmb()
        {
            string scalar = "Select * from dbo.fc_mostra_fornecedor()";
            acessoDados.LimparParametros();

            return acessoDados.ExecutarConsulta(CommandType.Text, scalar);
        }

        public DataTable PesquisarPorCod(string cod)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Produto", cod);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_produto");

            return dataTable;

        }
        public DataTable PesquisarPorDescricao(string descricao)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Descricao", descricao);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_produto");

            return dataTable;

        }

        public DataTable PesquisarTodos()
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            
            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_produto");

            return dataTable;

        }

    }
}
