using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    class Usuario
    {
        public String Login { get; set; }
        public String Senha { get; set; }

        public String CPF { get; set; }


        public Usuario()
        {

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public int Inserir(Usuario usuario)
        {
            /*string scalar = "Select dbo.buscarIDPessoa('" + cliente.CPF + "')";
              acessoDados.LimparParametros();

              object CPF = acessoDados.ExecutarConsultaScalar(CommandType.Text, scalar);

              if (!CPF.Equals(""))
                  acessoDados.AdicionarParametros("@Funcao", 1);//alterar
              else
                  acessoDados.AdicionarParametros("@Funcao", 2);//cadastrar*/

            acessoDados.AdicionarParametros("@CPF", usuario.CPF);
            acessoDados.AdicionarParametros("@Login", usuario.Login);
            acessoDados.AdicionarParametros("@Senha", usuario.Senha);
       

            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_usuario");
        }

        public DataTable PesquisarPorNome(string nomeUsuario)
        {
            List<Usuario> listaFuncionario = new List<Usuario>();

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Nome", nomeUsuario);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_usuario");

            return dataTable;

        }



        public Cliente Pesquisarcliente(String tipo_Pesquisa)
        {
            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@CPF", CPF);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_usuario");

            Cliente cliente = new Cliente();

            cliente.CPF = Convert.ToString(dataTable.Rows[0]["CPF_Pessoa"]);

            return cliente;
        }

    }
}
