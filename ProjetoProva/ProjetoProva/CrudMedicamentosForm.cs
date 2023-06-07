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
    public partial class CrudMedicamentosForm : Form
    {
        public CrudMedicamentosForm()
        {
            InitializeComponent();
            Text = "Novo Medicamento";
            idTextBox.Text = "Automático";
            idTextBox.ReadOnly = true;
            nomeTextBox.Focus();
        }

        public CrudMedicamentosForm(int id)
        {
            InitializeComponent();
            var medicamento = new MedicamentoDAO().Buscar(id);

            Text = "Alteração de Medicamentos";
            idTextBox.Text = medicamento.id.ToString();
            idTextBox.ReadOnly = true;
            nomeTextBox.Text = medicamento.Nome;
            nomeTextBox.Focus();

           quantidadeTextBox.Text = medicamento.Quantidade.ToString();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            if(Text == "Novo Medicamento")
            {
                new MedicamentoDAO().Adicionar(nomeTextBox.Text, Convert.ToInt32(quantidadeTextBox.Text));
                MessageBox.Show("Medicamento adicionado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                new MedicamentoDAO().Atualizar(Convert.ToInt32(idTextBox.Text), nomeTextBox.Text, Convert.ToInt32(quantidadeTextBox.Text));
                MessageBox.Show("Medicamento alterado com sucesso!", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close() ;
            }
        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
