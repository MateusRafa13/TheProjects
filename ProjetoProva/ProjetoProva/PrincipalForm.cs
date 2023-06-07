using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProva.Formularios
{
    public partial class principalForm : Form
    {
        public principalForm()
        {
            InitializeComponent();
        }


        void VerificarLogin()
        {
            if (Sessao.UsuarioLogado == null)
            {
             
                loginToolStripButton.Text = "Entrar";
                loginToolStripButton.Image = ProjetoProva.Properties.Resources.cadeado_aberto;
                usuarioToolStripStatusLabel.Text = "Não Autenticado";


             
                medicamentosToolStripButton.Enabled = false;
                pacientesToolStripButton.Enabled = false;
                usuariosToolStripButton.Enabled = false;

                pacientesToolStripMenuItem.Enabled = false;
                perfilToolStripMenuItem.Enabled = false;
                medicamentosToolStripMenuItem.Enabled = false; 
                usuariosToolStripMenuItem.Enabled = false;



            }
            else
            {
               

                loginToolStripButton.Text = "Sair";
                loginToolStripButton.Image = ProjetoProva.Properties.Resources.cadeado_fechado;
                usuarioToolStripStatusLabel.Text = "Bem-Vindo "+ Sessao.UsuarioLogado.Nome;


                pacientesToolStripMenuItem.Enabled = Sessao.UsuarioLogado.AcessaInternados;
                perfilToolStripMenuItem.Enabled = Sessao.UsuarioLogado.ativo;
                usuariosToolStripMenuItem.Enabled = Sessao.UsuarioLogado.AcessaUsuarios;
                medicamentosToolStripMenuItem.Enabled = Sessao.UsuarioLogado.AcessaMedicamentos;

                medicamentosToolStripButton.Enabled = Sessao.UsuarioLogado.AcessaMedicamentos;
                pacientesToolStripButton.Enabled = Sessao.UsuarioLogado.AcessaInternados;
                usuariosToolStripButton.Enabled = Sessao.UsuarioLogado.AcessaUsuarios;
            }
        }


        private void loginToolStripButton_Click(object sender, EventArgs e)
        {
            Sessao.UsuarioLogado = null;
            VerificarLogin();

            new LoginForm().ShowDialog();
            VerificarLogin();
    

        }

        private void principalForm_Load(object sender, EventArgs e)
        {

        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PacientesForm pacienteForm = new PacientesForm();
            pacienteForm.MdiParent = this;
            pacienteForm.Show();
        }

        private void pacientesToolStripButton_Click(object sender, EventArgs e)
        {
            PacientesForm pacienteForm = new PacientesForm();
            pacienteForm.MdiParent = this;
            pacienteForm.Show();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sessao.UsuarioLogado == null)
                return;

            new MeuPerfilForm().ShowDialog();

            VerificarLogin();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarioForm = new UsuariosForm();
            usuarioForm.MdiParent = this;
            usuarioForm.Show();
        }

        private void medicamentosToolStripButton_Click(object sender, EventArgs e)
        {

            MedicamentosForm medicamentoForm = new MedicamentosForm();
            medicamentoForm.MdiParent = this;
            medicamentoForm.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicamentosForm medicamentoForm = new MedicamentosForm();
            medicamentoForm.MdiParent = this;
            medicamentoForm.Show();
        }

        private void usuariosToolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarioForm = new UsuariosForm();
            usuarioForm.MdiParent = this;
            usuarioForm.Show(); 
        }
    }
}
