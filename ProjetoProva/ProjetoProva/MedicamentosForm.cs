using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoProva.Negocio;

namespace ProjetoProva
{
    public partial class MedicamentosForm : Form
    {
        public MedicamentosForm()
        {
            InitializeComponent();
        }

        private void listarButton_Click(object sender, EventArgs e)
        {
            var dados = new MedicamentoDAO().ListarTodas();
            dataGridView.DataSource = dados;

            qtdToolStripStatusLabel.Text = $"Registros encontrados: {dados.Count}";
            
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
           new CrudMedicamentosForm().ShowDialog();
            listarButton.PerformClick();
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
            new CrudMedicamentosForm(id).ShowDialog();
            listarButton.PerformClick();
        }

        private void MedicamentosForm_Load(object sender, EventArgs e)
        {

        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirma a exclusão do Medicamento?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["idColumn"].Value);
                new MedicamentoDAO().Excluir(id);
                listarButton.PerformClick();
                MessageBox.Show("Medicamento excluido com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
