using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoProva.Negocios;


namespace ProjetoProva
{
    public partial class LoginForm : Form

    {
        public LoginForm()
        {
            InitializeComponent();
            Application.DoEvents();
            emailTextBox.Text = ProjetoProva.Properties.Settings.Default.email;
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void entrarButton_Click(object sender, EventArgs e)
        {
            Sessao.UsuarioLogado = new UsuarioDAO().Login(emailTextBox.Text, senhaTextBox.Text);

            if(Sessao.UsuarioLogado == null)
            {
                emailTextBox.Focus();
                senhaTextBox.Clear();


                MessageBox.Show("Usuário ou senha inválido!!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if(Sessao.UsuarioLogado.ativo == false)
            {
                Sessao.UsuarioLogado = null;

                MessageBox.Show("O usuário está inativo", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ProjetoProva.Properties.Settings.Default.email = emailTextBox.Text;
            ProjetoProva.Properties.Settings.Default.Save();

            Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
