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
    public partial class PacientesForm : Form
    {
        public PacientesForm()
        {
            InitializeComponent();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var dados = new PacienteDAO().ListarTodas();
            dataGridView.DataSource = dados;
            qtdToolStripStatusLabel.Text = $"Registros Encontrados: {dados.Count}";

        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
            new CrudPacientesForm().ShowDialog();
            listarButton.PerformClick();
        }


        private void alterarButton_Click(object sender, EventArgs e)
        {
            //pega o id da linha selecionada no grid
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
            //abre a tela para um novo cadastro
            new CrudPacientesForm(id).ShowDialog();
            //executa a busca novamente, como se tivesse clicado no botão
            listarButton.PerformClick();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do Paciente?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);

                new PacienteDAO().Excluir(id);

                listarButton.PerformClick();

                MessageBox.Show("Produto excluido com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
