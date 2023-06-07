using ProjetoProva.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProva
{
    public partial class CrudPacientesForm : Form
    {
        public CrudPacientesForm()
        {
            InitializeComponent();
            Text = "Novo Paciente";
            idTextBox.Text = "Automático";
            idTextBox.ReadOnly = true;
            idAlaTextBox.Focus();

            idAlaTextBox.TabIndex = 1;
            nomeTextBox.TabIndex = 2;
            cpfTextBox.TabIndex = 3;
            rgTextBox.TabIndex = 4;
            celularTextBox.TabIndex = 5;
        }

        public CrudPacientesForm(int id)
        {
            InitializeComponent();
            var paciente = new PacienteDAO().Buscar(id);

            Text = "Alteração de Paciente";
            idTextBox.Text = paciente.id.ToString();
            idTextBox.ReadOnly = true;

            idAlaTextBox.Text = paciente.id_alas.ToString();
            idAlaTextBox.Focus();
            nomeTextBox.Text = paciente.Nome;
            cpfTextBox.Text = paciente.CPF;
            rgTextBox.Text = paciente.RG;
            celularTextBox.Text = paciente.Celular;
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if(Text == "Novo Paciente")
            {
                new PacienteDAO().Adicionar(Convert.ToInt32(idAlaTextBox.Text), nomeTextBox.Text, cpfTextBox.Text, rgTextBox.Text, celularTextBox.Text);
                MessageBox.Show("Paciente Adicionado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                new PacienteDAO().Atualizar(Convert.ToInt32(idTextBox.Text), Convert.ToInt32(idAlaTextBox.Text), nomeTextBox.Text, cpfTextBox.Text, rgTextBox.Text, celularTextBox.Text);
                MessageBox.Show("Paciente Atualizado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
        }

        private void CrudPacientesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
