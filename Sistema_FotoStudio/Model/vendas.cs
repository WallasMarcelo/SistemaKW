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
        public String Cod_venda { get; set; }
        public int Cod_cliente { get; set; }
        public String Nome_Cliente { get; set; }
        public String Nome_Funcionario { get; set; }
        public string CPF { get; set; }
        public int Cod_funcionario { get; set; }
        public DateTime Data_venda { get; set; }
        public DataTable ItensVendas { get; set; }

      
        public Vendas()
        {
          

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();

        public int Inserir(Vendas Vendas)
        {
          
            if(Vendas.Cod_venda.Equals(""))
                acessoDados.AdicionarParametros("@FUNCAO", 1);
            else
                acessoDados.AdicionarParametros("@FUNCAO", 2);

            acessoDados.AdicionarParametros("@CPF", Vendas.CPF);
            acessoDados.AdicionarParametros("@COD_FUNCIONARIO", Vendas.Cod_funcionario);
            acessoDados.AdicionarParametros("@DATA_VENDA", Vendas.Data_venda);

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Vendas");

        }

        public int InserirItemVenda(Vendas vendas)
        {
            int funcao = 0;

            if (vendas.Cod_venda.Equals(""))
                funcao = 1;//inserir
            else
                funcao = 2;//alterar

            Cod_venda = Convert.ToString(Inserir(vendas));
            

            for (int i = 0; i < vendas.ItensVendas.Rows.Count; i++)
            {
                acessoDados.LimparParametros();
                acessoDados.AdicionarParametros("@Funcao", funcao);
                acessoDados.AdicionarParametros("@COD_VENDA", Cod_venda);
                acessoDados.AdicionarParametros("@QUANTIDADE", Convert.ToInt32(vendas.ItensVendas.Rows[i]["Quantidade"]));
                acessoDados.AdicionarParametros("@VALORUNITARIO", Convert.ToDecimal(vendas.ItensVendas.Rows[i]["Valor Unitário"]));

                if(vendas.ItensVendas.Rows[i]["Tipo"].Equals("Produto"))
                    acessoDados.AdicionarParametros("@COD_PRODUTO", Convert.ToInt32(vendas.ItensVendas.Rows[i]["Código"]));
                else
                    acessoDados.AdicionarParametros("@COD_SERVICO", Convert.ToInt32(vendas.ItensVendas.Rows[i]["Código"]));

                acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_Item_Venda");
            }

            return Convert.ToInt32(Cod_venda);
        }


     
        public Vendas PesquisarPorCodigo(int Codigo)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Venda", Codigo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_Vendas");

            return PassarValores(new Vendas(), dataTable);
        }

        public DataTable PesquisarPorCodigoTabela(String Codigo)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod_Venda", Codigo);

            return acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_Vendas");

            
        }


        public DataTable PesquisarVendaPorCPF(String CPF)
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

        public DataTable PesquisarPorTodos()
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 4);

            return acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_Vendas");

        }

        public DataTable PesquisarItemVenda(int CodigoVenda)
        {
            string scalar = "Select * from dbo. fc_busca_item_venda('" + CodigoVenda + "')";
            acessoDados.LimparParametros();

            return acessoDados.ExecutarConsulta(CommandType.Text, scalar);
        }

        public String PequisarCliente(String CPF)
        {
            string scalar = "Select dbo. fc_busca_cliente('" + CPF + "')";
            acessoDados.LimparParametros();

            return acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar).ToString();
        }

        public String PequisarFuncionario(String Codigo)
        {
            string scalar = "Select dbo. fc_busca_funcionario('" + Codigo + "')";
            acessoDados.LimparParametros();

            return acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar).ToString();
        }

        public String PequisarProduto(String Codigo)
        {
            string scalar = "Select * from dbo. fc_busca_produto('" + Codigo + "')";
            acessoDados.LimparParametros();

            return acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar).ToString();
        }

        public DataTable PequisarServiço(String Codigo)
        {
            string scalar = "Select * from dbo. fc_busca_servico('" + Codigo + "')";
            acessoDados.LimparParametros();

            return acessoDados.ExecutarConsulta(CommandType.Text, scalar);
        }

        public Vendas PassarValores(Vendas vendas, DataTable dataTable)
        {
            vendas.Cod_venda = Convert.ToString(dataTable.Rows[0]["Código"]);
            vendas.Cod_cliente = Convert.ToInt32(dataTable.Rows[0]["Cod_Cliente"]);
            vendas.CPF = Convert.ToString(dataTable.Rows[0]["CPF"]);
            vendas.Nome_Cliente = Convert.ToString(dataTable.Rows[0]["Cliente"]);
            vendas.Cod_funcionario = Convert.ToInt32(dataTable.Rows[0]["Cod_funcionario"]);
            vendas.Nome_Funcionario = Convert.ToString(dataTable.Rows[0]["Funcionario"]);
            vendas.Data_venda = Convert.ToDateTime(dataTable.Rows[0]["Data_Venda"]);

            return vendas;
        }

    }

}
