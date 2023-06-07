namespace ProjetoProva
{
    partial class UsuariosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessausuariosColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acessainternadosColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acessamedicamentosColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ativoColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.qtdToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.nomeColumn,
            this.categoriaColumn,
            this.senhaColumn,
            this.acessausuariosColumn,
            this.acessainternadosColumn,
            this.acessamedicamentosColumn,
            this.ativoColumn});
            this.dataGridView.Location = new System.Drawing.Point(-1, 83);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(946, 361);
            this.dataGridView.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 80;
            // 
            // nomeColumn
            // 
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome do Usuário";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            this.nomeColumn.Width = 200;
            // 
            // categoriaColumn
            // 
            this.categoriaColumn.DataPropertyName = "email";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.categoriaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriaColumn.HeaderText = "E-mail";
            this.categoriaColumn.Name = "categoriaColumn";
            this.categoriaColumn.ReadOnly = true;
            this.categoriaColumn.Width = 300;
            // 
            // senhaColumn
            // 
            this.senhaColumn.DataPropertyName = "senha";
            this.senhaColumn.HeaderText = "Senha";
            this.senhaColumn.Name = "senhaColumn";
            this.senhaColumn.ReadOnly = true;
            this.senhaColumn.Visible = false;
            // 
            // acessausuariosColumn
            // 
            this.acessausuariosColumn.DataPropertyName = "AcessaUsuarios";
            this.acessausuariosColumn.HeaderText = "Acessa Usuários";
            this.acessausuariosColumn.Name = "acessausuariosColumn";
            this.acessausuariosColumn.ReadOnly = true;
            this.acessausuariosColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acessausuariosColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // acessainternadosColumn
            // 
            this.acessainternadosColumn.DataPropertyName = "AcessaInternados";
            this.acessainternadosColumn.HeaderText = "Acessa Internados";
            this.acessainternadosColumn.Name = "acessainternadosColumn";
            this.acessainternadosColumn.ReadOnly = true;
            this.acessainternadosColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acessainternadosColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // acessamedicamentosColumn
            // 
            this.acessamedicamentosColumn.DataPropertyName = "AcessaMedicamentos";
            this.acessamedicamentosColumn.HeaderText = "Acessa Medicamentos";
            this.acessamedicamentosColumn.Name = "acessamedicamentosColumn";
            this.acessamedicamentosColumn.ReadOnly = true;
            this.acessamedicamentosColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acessamedicamentosColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ativoColumn
            // 
            this.ativoColumn.DataPropertyName = "ativo";
            this.ativoColumn.HeaderText = "Ativo";
            this.ativoColumn.Name = "ativoColumn";
            this.ativoColumn.ReadOnly = true;
            this.ativoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(12, 36);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(75, 23);
            this.listarButton.TabIndex = 5;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(864, 467);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 18;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(783, 467);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 17;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(702, 467);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 16;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(621, 467);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 15;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qtdToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // qtdToolStripStatusLabel
            // 
            this.qtdToolStripStatusLabel.Name = "qtdToolStripStatusLabel";
            this.qtdToolStripStatusLabel.Size = new System.Drawing.Size(127, 17);
            this.qtdToolStripStatusLabel.Text = "Registros Encontrados:";
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 546);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.alterarButton);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.listarButton);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button listarButton;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button alterarButton;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel qtdToolStripStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acessausuariosColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acessainternadosColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acessamedicamentosColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoColumn;
    }
}