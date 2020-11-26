using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_FotoStudio.Model;
using Sistema_FotoStudio.View;
using System.Data;


namespace Sistema_FotoStudio.Controller
{
    public class ProdutoController
    {
        public int cadastroProduto(String cod_produto,int cod_fornecedor, String marca, String lote, int quantidade, String descricaoProduto)
        {
            Produto produto = new Produto();

            produto.cod_produto = cod_produto;
            produto.cod_fornecedor = cod_fornecedor;
            produto.marca = marca;
            produto.lote = lote;
            produto.quantidade = quantidade;
            produto.descricao = descricaoProduto;

            return produto.ManterProduto(produto);
        }

        public DataTable buscaFornecedorCmb()
        {
            Produto produto = new Produto();

            return produto.buscaFornecedorCmb();
        }

        public DataTable PesquisarPorCodigo(string Codigo)
        {
            Produto produto = new Produto();
            return produto.PesquisarPorCod(Codigo);
        }

        public Produto PesquisarPorCodigo(int Codigo)
        {
            Produto produto = new Produto();
            return produto.PesquisarPorCodigo(Codigo.ToString());
        }

        public DataTable PesquisarPorDescricao(string descricao)
        {
            Produto produto = new Produto();
            return produto.PesquisarPorDescricao(descricao);
        }

        public int Inativar(int cod)
        {
            Produto produto = new Produto();
            return produto.inativarProduto(cod);
            ;
        }

        public DataTable PesquisarTodos()
        {
            Produto produto = new Produto();
            return produto.PesquisarTodos();
        }

    }
}
