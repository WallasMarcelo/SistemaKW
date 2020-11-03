using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Vendas
    {
        int Cod_venda { get; set; }
        int Cod_cliente { get; set; }
        int Cod_funcionario { get; set; }
        DateTime Data_venda { get; set; }
        int Cod_item_venda { get; set; }
        int Cod_produto { get; set; }
        int Cod_servico { get; set; }
        int quantidade { get; set; }
        decimal valor_unitario { get; set; }
      




        public Vendas()
        {

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Vendas Vendas)
        {
          

            acessoDados.AdicionarParametros("@FUNCAO", 1);
            acessoDados.AdicionarParametros("@COD_CLIENTE", Vendas.Cod_cliente);
            acessoDados.AdicionarParametros("@COD_FUNCIONARIO", Vendas.Cod_funcionario);
            acessoDados.AdicionarParametros("@DATA_VENDA", Vendas.Data_venda);

            if(Convert.ToString(Vendas.Cod_produto) != "" )
            {
                acessoDados.AdicionarParametros("@COD_PRODUTO", Vendas.Cod_produto);
            }
            else
            {
                acessoDados.AdicionarParametros("@COD_PRODUTO", null);
            }


            if (Convert.ToString(Vendas.Cod_servico) != "")
               acessoDados.AdicionarParametros("@COD_SERVICO", Vendas.Cod_servico);
            else
                acessoDados.AdicionarParametros("@COD_SERVICO", null);
           

            acessoDados.AdicionarParametros("@COD_VENDA", Vendas.Cod_venda);
            acessoDados.AdicionarParametros("@QUANTIDADE", Vendas.quantidade);
            acessoDados.AdicionarParametros("@VALORUNITARIO", Vendas.valor_unitario);
            acessoDados.AdicionarParametros("@COD_ITEM_VENDA", Vendas.Cod_item_venda);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Vendas");
        }


        public int alterar(Vendas Vendas)
        {
            acessoDados.AdicionarParametros("@FUNCAO", 2);
            acessoDados.AdicionarParametros("@COD_CLIENTE", Vendas.Cod_cliente);
            acessoDados.AdicionarParametros("@COD_FUNCIONARIO", Vendas.Cod_funcionario);
            acessoDados.AdicionarParametros("@DATA_VENDA", Vendas.Data_venda);

            if (Vendas.Cod_produto != null)
            {
                acessoDados.AdicionarParametros("@COD_PRODUTO", Vendas.Cod_produto);
            }
            else
            {
                acessoDados.AdicionarParametros("@COD_SERVICO", Vendas.Cod_servico);
            }

            acessoDados.AdicionarParametros("@COD_VENDA", Vendas.Cod_venda);
            acessoDados.AdicionarParametros("@QUANTIDADE", Vendas.quantidade);
            acessoDados.AdicionarParametros("@VALORUNITARIO", Vendas.valor_unitario);
            acessoDados.AdicionarParametros("@COD_ITEM_VENDA", Vendas.Cod_item_venda);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Vendas");
        }

        public DataTable PesquisarVendaCod(String Cod_venda)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_venda", Cod_venda);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_Vendas");

            return dataTable;

        }

        public DataTable PesquisarVendaCPF(String CPF)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@cpf", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_Vendas");

            return dataTable;
        }

        public DataTable PesquisarPorNome(string Nome)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@nome_cliente", Nome);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_Vendas");

            return dataTable;

        }

        public String BusarNome(String CPF)
        {


            acessoDados.ExecutarConsultaScalar("fc_buscar");

            return null;
        }

    }

}
