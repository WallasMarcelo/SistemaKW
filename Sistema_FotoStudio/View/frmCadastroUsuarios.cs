using Sistema_FotoStudio.Controller;
using Sistema_FotoStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FotoStudio.View
{
    public partial class frmCadastroUsuarios : frmBase
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        private string codigo { get => txtCod_Funcionario.Text; set => txtCod_Funcionario.Text = value; }
        private string Login { get => txtLogin.Text; set => txtLogin.Text = value; }
        private string Senha { get => txtSenha.Text; set => txtSenha.Text = value; }
        private int Situacao
        {
            get
            {
                if (rbSim.Checked)
                    return 1;
                else
                    return 0;
            }

            set
            {
                if (value == 1)
                    rbSim.Checked = true;
                else
                    rbNao.Checked = true;
            }
        } 

       private int Tipo 
        {
            get
            {
                if (cmbTipoUsuario.Text.Equals("Usuário"))
                    return 1;
                else
                    return 2;
            }

            set
            {
                if (value == 1)
                    cmbTipoUsuario.SelectedItem = cmbTipoUsuario.FindString("Usuário");
                else
                    cmbTipoUsuario.SelectedItem = cmbTipoUsuario.FindString("Administração");
            }
        
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(codigo != "" ||  !Login.Equals("") || (!Senha.Equals("") && Senha.Length < 6) || !Situacao.Equals("") || !Tipo.Equals(""))
            {
                UsuarioController usuarioController = new UsuarioController();
                
                if(usuarioController.Inserir(codigo,Login,Senha,Tipo,Situacao) == 1)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar usuario");
                }

            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           UsuarioController usuarioController = new UsuarioController();


            if (!codigo.Equals(""))
            {
                Usuario usuario = usuarioController.pesquisarPorCodigo(codigo);

                PassarValores(usuario);
                return;

            }


           // usuarioController.PesquisarPorNome(Usuario, this, this.principal);
        }


        public void PassarValores(Usuario usuario)
        {
            codigo = usuario.Cod_funcionario.ToString();
            Login = usuario.Login;
            Tipo = usuario.Tipo;
            Situacao = usuario.situacao;
            
        }
    }
}
