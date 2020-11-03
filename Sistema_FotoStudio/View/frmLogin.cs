using Sistema_FotoStudio.Controller;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private String Login { get => txtUsuario.Text; set => txtUsuario.Text = value; }
        private String Senha { get => txtSenha.Text; set => txtSenha.Text = value; }

        private void botaoCircular1_Click(object sender, EventArgs e)
        {
            if (Login.Equals(""))
            {
                MessageBox.Show("Por favor, Preencha o campo Login");
                return;
            }

            if (Senha.Equals(""))
            {
                MessageBox.Show("Por favor, Preencha o campo Senha");
                return;
            }

            UsuarioController usuario = new UsuarioController();
            DataTable tipo = usuario.ValidarLogin(Login, Senha);

            if (tipo.Rows.Count != 0)
            {
                frmPrincipal principal = new frmPrincipal(Convert.ToString(tipo.Rows[0]["Tipo"]));
                principal.Show();
                this.Visible = false;
              
            }
            else
            {
                MessageBox.Show("Usuario ou senha está incorreto");
            }

        }
    }
}
