using ProjetoProva.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProva
{
    public partial class MeuPerfilForm : Form
    {
        public MeuPerfilForm()
        {
            InitializeComponent();

            Application.DoEvents();

            idTextBox.Text = Sessao.UsuarioLogado.id.ToString();
            nomeTextBox.Text = Sessao.UsuarioLogado.Nome;
            emailTextBox.Text = Sessao.UsuarioLogado.email;

        
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            if (!usuarioDAO.CompararSenhas(Sessao.UsuarioLogado.id, senhaAtualTextBox.Text))
            {
                MessageBox.Show("Senha atual não confere!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                senhaAtualTextBox.Focus();
                return;
            }

            var usuario = Sessao.UsuarioLogado;
            usuario.Nome = nomeTextBox.Text.Trim();
            usuario.email = emailTextBox.Text.Trim();


            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(usuario.email);
            if (!match.Success)
            {
                MessageBox.Show("O email não é válido!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailTextBox.Focus();
                return;
            }


            usuarioDAO.AlteraPerfil(usuario);

            if(novaSenha1TextBox.Text.Length > 0)
            {
                if(novaSenha1TextBox.Text != novaSenha2TextBox.Text)
                {
                    MessageBox.Show("As novas senhas não conferem!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    novaSenha1TextBox.Clear();
                    novaSenha2TextBox.Clear();
                    novaSenha1TextBox.Focus();
                    return;
                }

                usuario.senha = novaSenha1TextBox.Text.Trim();
                usuarioDAO.AlterarSenha(usuario);
            }

            MessageBox.Show("Dados alterados com sucesso, refaça o login", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sessao.UsuarioLogado = null;
            Close();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
