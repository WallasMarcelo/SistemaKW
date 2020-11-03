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

        public int cod_produto { get; set; }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();
        public int InserirProduto(Produto produto)
        {
            acessoDados.AdicionarParametros("@Funcao", "1");
            acessoDados.AdicionarParametros("@Descricao", produto.descricao);
            acessoDados.AdicionarParametros("@Quantidade", produto.quantidade);
            acessoDados.AdicionarParametros("@Marca", produto.marca);
            acessoDados.AdicionarParametros("@Lote", produto.lote);
            acessoDados.AdicionarParametros("@Situacao", produto.situacao);
            acessoDados.AdicionarParametros("@Cod_Fornecedor", produto.cod_fornecedor);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_produto");
        }

        public void alterarProduto(Produto produto)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Descricao", produto.descricao);
            acessoDados.AdicionarParametros("@Quantidade", produto.quantidade);
            acessoDados.AdicionarParametros("@Marca", produto.marca);
            acessoDados.AdicionarParametros("@Lote", produto.lote);
            acessoDados.AdicionarParametros("@Situacao", produto.situacao);
            acessoDados.AdicionarParametros("@Cod_Fornecedor", produto.cod_fornecedor);

            acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_produto");

        }

        public void inativarProduto(Produto produto)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Cod_produto", produto.cod_produto);

            acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_produto");
        }

        public Produto PesquisarPorCodigo(int COD)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Produto", COD);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_produto");

            Produto produto = new Produto();

            produto.cod_fornecedor = Convert.ToInt32(dataTable.Rows[0]["cod_produto"]);
            produto.descricao = Convert.ToString(dataTable.Rows[0]["Descricao"]);
            produto.quantidade = Convert.ToInt32(dataTable.Rows[0]["Quantidade"]);
            produto.marca = Convert.ToString(dataTable.Rows[0]["Marca"]);
            produto.lote = Convert.ToString(dataTable.Rows[0]["Lote"]);
            produto.situacao = Convert.ToInt32(dataTable.Rows[0]["Situacao"]);

            return produto;
        }

        public DataTable PesquisarPorDescricao(Produto produto)
        {
            List<Produto> ListaProduto = new List<Produto>();


            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Descricao", produto.descricao);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_produto");

            return dataTable;
        }
    }
}
