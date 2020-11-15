using Sistema_FotoStudio.Banco_de_dados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Model
{
    public class Usuario
    {
        public String Login { get; set; }
        public String Senha { get; set; }

        public int Cod_funcionario { get; set; }

        public int Tipo { get; set; }

        public int situacao { get; set; }


        public Usuario()
        {

        }

        AcessoDadosSqlServer acessoDados = new AcessoDadosSqlServer();


        public int Inserir(Usuario usuario, bool alterar)
        {
            
            if(alterar)
                acessoDados.AdicionarParametros("@Funcao", 2);//alterar
            else
                acessoDados.AdicionarParametros("@Funcao", 1);//cadastrar

            acessoDados.AdicionarParametros("@Cod_Funcionario", usuario.Cod_funcionario);
            acessoDados.AdicionarParametros("@Tipo", usuario.Tipo);
            acessoDados.AdicionarParametros("@Login", usuario.Login);
            acessoDados.AdicionarParametros("@Senha", usuario.Senha);
            acessoDados.AdicionarParametros("@Situacao", usuario.situacao);


            return acessoDados.ExecutarManipulacao(CommandType.StoredProcedure, "sp_usuario");
        }

        public Usuario PesquisarPorCodigo(string codigo)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 1);
            acessoDados.AdicionarParametros("@Cod", codigo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_usuario");

            Usuario usuario = new Usuario();

            usuario.Cod_funcionario =  Convert.ToInt32(dataTable.Rows[0]["Cod_funcionario"]);
            usuario.Login = Convert.ToString(dataTable.Rows[0]["Login"]);
            usuario.Tipo = Convert.ToInt32(dataTable.Rows[0]["tipo"]);
            usuario.situacao = Convert.ToInt32(dataTable.Rows[0]["situacao"]);

            return usuario;


        }

        public DataTable PesquisarPorNome(string nomeUsuario)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 2);
            acessoDados.AdicionarParametros("@Usuario", nomeUsuario);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_usuario");

            return dataTable;

        }

        public DataTable PesquisarPorCodigoTabela(string Codigo)
        {

            acessoDados.LimparParametros();
            acessoDados.AdicionarParametros("@Funcao", 3);
            acessoDados.AdicionarParametros("@Cod", Codigo);

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.StoredProcedure, "sp_pesquisar_usuario");

            return dataTable;

        }

        public DataTable ValidarLogin(String Login, String Senha)
        {
            string consulta = "Select * from dbo.fc_validar_login('"+ Login + "','" + Senha +  "')";
            acessoDados.LimparParametros();

            DataTable dataTable = acessoDados.ExecutarConsulta(CommandType.Text, consulta);

            return dataTable;
        }

    }
}
