using ProjetoProva.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProva
{
    public partial class CrudUsuariosForm : Form
    {
        public CrudUsuariosForm()
        {
            InitializeComponent();
            Text = "Novo Usuário";
            idTextBox.Text = "Automático";
            idTextBox.ReadOnly = true;
            nomeTextBox.Focus();
        }

        public CrudUsuariosForm(int id)
        {
            InitializeComponent ();
            var usuario = new UsuarioDAO().Buscar(id);

            Text = "Alteração de Usuário";
            idTextBox.Text = usuario.id.ToString();
            idTextBox.ReadOnly = true;

            nomeTextBox.Text = usuario.Nome;
            nomeTextBox.Focus ();
            emailTextBox.Text = usuario.email;
            senhaTextBox.Text = usuario.senha;
            acessaUsuarioCheckBox.Checked = usuario.AcessaUsuarios;
            acessaInternadoscheckBox.Checked = usuario.AcessaInternados;
            acessaMedcheckBox.Checked = usuario.AcessaMedicamentos;
            ativoCheckBox.Checked = usuario.ativo;
          

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {

            bool acessausuario = acessaUsuarioCheckBox.Checked;
            bool acessainternados = acessaInternadoscheckBox.Checked;
            bool acessamedicamentos = acessaMedcheckBox.Checked;
            bool ativo = ativoCheckBox.Checked;

            if (Text == "Novo Usuário")
            {
                new UsuarioDAO().Adicionar(nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, Convert.ToBoolean(acessausuario), 
                    Convert.ToBoolean(acessainternados), Convert.ToBoolean(acessamedicamentos), Convert.ToBoolean(ativo));
                MessageBox.Show("Usuário adicionado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {

      
    

                new UsuarioDAO().Atualizar(Convert.ToInt32(idTextBox.Text),nomeTextBox.Text, emailTextBox.Text, senhaTextBox.Text, 
                    Convert.ToBoolean(acessausuario), Convert.ToBoolean(acessainternados), Convert.ToBoolean(acessamedicamentos), Convert.ToBoolean(ativo));
                MessageBox.Show("Usuário alterado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }
    }
}
