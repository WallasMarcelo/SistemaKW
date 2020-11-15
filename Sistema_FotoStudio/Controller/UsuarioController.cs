using Sistema_FotoStudio.Criptografia;
using Sistema_FotoStudio.Model;
using Sistema_FotoStudio.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_FotoStudio.Controller
{
    public class UsuarioController
    {
        public int Inserir(String Codigo, String Login, String Senha, int Tipo, int Situacao, bool alterar)
        {

            Hash hash = new Hash(SHA512.Create());
            String SenhaCriptografada = hash.CriptografarSenha(Senha);

            Usuario usuario = new Usuario();
            usuario.Cod_funcionario = Convert.ToInt32(Codigo);
            usuario.Login = Login;
            usuario.Senha = SenhaCriptografada;
            usuario.Tipo = Convert.ToInt32(Tipo);
            usuario.situacao = Situacao;

            return usuario.Inserir(usuario,alterar);
        }

        public Usuario pesquisarPorCodigo(String codigo)
        {
            Usuario usuario = new Usuario();

            return usuario.PesquisarPorCodigo(codigo);
        }
        
        public void pesquisarPorNome(String Nome, frmCadastroUsuarios Cadastro, frmPrincipal principal)
        {
            Usuario usuario = new Usuario();
            DataTable tabela = usuario.PesquisarPorNome(Nome);//Resultados da pesquisa

            if (tabela.Rows.Count == 1)//Se a tabrla conter apenas um registro, não exibir a tabela
            {
                PassarCodigo(Convert.ToInt32(tabela.Rows[0]["Cod_funcionario"].ToString()), Cadastro);//Chamar o método PassarCPF 
                return;
            }

            frmPesquisaResultadoUsuario pesquisa = new frmPesquisaResultadoUsuario(tabela, Cadastro);//Criar objeto PesquisaResultado
            pesquisa.MdiParent = principal;
            pesquisa.Show();//Mostrar o objeto
        }


        public DataTable ValidarLogin(String Login, String Senha)
        {
            Hash hash = new Hash(SHA512.Create());

            Usuario usuario = new Usuario();
            return usuario.ValidarLogin(Login, hash.CriptografarSenha(Senha));

           
        }

        public void PassarCodigo(int Codigo, frmCadastroUsuarios cadastroUsuarios)
        {
            Usuario usuario = pesquisarPorCodigo(Convert.ToString(Codigo));//Realizar pesquisa pela cpf da linha escolhida do DAtaGrd
            cadastroUsuarios.PassarValores(usuario);//Cahmar método passarValores do Forms


        }
    }
}
