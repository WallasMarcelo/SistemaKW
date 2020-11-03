using Sistema_FotoStudio.Criptografia;
using Sistema_FotoStudio.Model;
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
        public int Inserir(String Codigo, String Login, String Senha, int Tipo, int Situacao)
        {

            Hash hash = new Hash(SHA512.Create());
            String SenhaCriptografada = hash.CriptografarSenha(Senha);

            Usuario usuario = new Usuario();
            usuario.Cod_funcionario = Convert.ToInt32(Codigo);
            usuario.Login = Login;
            usuario.Senha = SenhaCriptografada;
            usuario.Tipo = Convert.ToInt32(Tipo);
            usuario.situacao = Situacao;

            return usuario.Inserir(usuario);
        }

        public Usuario pesquisarPorCodigo(String codigo)
        {
            Usuario usuario = new Usuario();

            return usuario.PesquisarPorCodigo(codigo);
        } 


        public DataTable ValidarLogin(String Login, String Senha)
        {
            Hash hash = new Hash(SHA512.Create());

            Usuario usuario = new Usuario();
            return usuario.ValidarLogin(Login, hash.CriptografarSenha(Senha));

           
        } 
    }
}
