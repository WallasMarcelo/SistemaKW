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
    public class ServicoController
    {
        public int cadastrarServico(String cod_servico, String tipoServico, String descricao, string valor)
        {
            Servico servico = new Servico();

            servico.Cod_Servico = cod_servico;
            servico.Tipo = tipoServico;
            servico.Descricao = descricao;
            servico.Valor = Convert.ToDecimal(valor);

            return servico.InserirServicos(servico);
        }

        public Servico PesquisarPorCodigo(int cod)
        {
            Servico servico = new Servico();
            return servico.PesquisarPorCodigo(cod);
        }

        public int Inativar(int cod)
        {
            Servico servico = new Servico();
            return servico.InativarServico(cod);
            ;
        }

        public DataTable pesquisaPorTipoServico(String tipoServico)
        {
            Servico servico = new Servico();
            return servico.PesquisaServico(tipoServico);

        }

        public DataTable pesquisaPorCodServico(String cod)
        {
            Servico servico = new Servico();
            return servico.PesquisaCod(cod);

        }

        public DataTable pesquisaTodosServicos()
        {
            Servico servico = new Servico();
            return servico.PesquisarTodosServico();

        }

    }
}