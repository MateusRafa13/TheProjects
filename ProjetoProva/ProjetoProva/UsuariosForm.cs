using ProjetoProva.Negocios;
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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var dados = new UsuarioDAO().ListarTodas();

            dataGridView.DataSource = dados;
            qtdToolStripStatusLabel.Text = $"Registros encontrados: {dados.Count}";

        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
            new CrudUsuariosForm().ShowDialog();
            listarButton.PerformClick();
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
            new CrudUsuariosForm(id).ShowDialog();
            listarButton.PerformClick();
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão do Usuário?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
                new UsuarioDAO().Excluir(id);
                listarButton.PerformClick();

                MessageBox.Show("Usuário excluído com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
