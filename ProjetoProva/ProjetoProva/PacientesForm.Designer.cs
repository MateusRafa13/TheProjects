﻿namespace ProjetoProva
{
    partial class PacientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PacientesForm));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.listarButton = new System.Windows.Forms.Button();
            this.fecharButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.alterarButton = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.qtdToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.idalasColumn,
            this.nomeColumn,
            this.categoriaColumn,
            this.valorColumn,
            this.celularColumn});
            this.dataGridView.Location = new System.Drawing.Point(-3, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(806, 287);
            this.dataGridView.TabIndex = 2;
            // 
            // listarButton
            // 
            this.listarButton.Location = new System.Drawing.Point(12, 24);
            this.listarButton.Name = "listarButton";
            this.listarButton.Size = new System.Drawing.Size(75, 23);
            this.listarButton.TabIndex = 3;
            this.listarButton.Text = "Listar";
            this.listarButton.UseVisualStyleBackColor = true;
            this.listarButton.Click += new System.EventHandler(this.listarButton_Click);
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(716, 382);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 10;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(635, 382);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(75, 23);
            this.novoButton.TabIndex = 9;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // alterarButton
            // 
            this.alterarButton.Location = new System.Drawing.Point(554, 382);
            this.alterarButton.Name = "alterarButton";
            this.alterarButton.Size = new System.Drawing.Size(75, 23);
            this.alterarButton.TabIndex = 8;
            this.alterarButton.Text = "Alterar";
            this.alterarButton.UseVisualStyleBackColor = true;
            this.alterarButton.Click += new System.EventHandler(this.alterarButton_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(473, 382);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 7;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qtdToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // qtdToolStripStatusLabel
            // 
            this.qtdToolStripStatusLabel.Name = "qtdToolStripStatusLabel";
            this.qtdToolStripStatusLabel.Size = new System.Drawing.Size(127, 17);
            this.qtdToolStripStatusLabel.Text = "Registros Encontrados:";
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "ID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.idColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 80;
            // 
            // idalasColumn
            // 
            this.idalasColumn.DataPropertyName = "id_alas";
            this.idalasColumn.HeaderText = "Alas";
            this.idalasColumn.Name = "idalasColumn";
            this.idalasColumn.ReadOnly = true;
            // 
            // nomeColumn
            // 
            this.nomeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeColumn.DataPropertyName = "Nome";
            this.nomeColumn.HeaderText = "Nome do Paciente";
            this.nomeColumn.Name = "nomeColumn";
            this.nomeColumn.ReadOnly = true;
            // 
            // categoriaColumn
            // 
            this.categoriaColumn.DataPropertyName = "CPF";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.categoriaColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.categoriaColumn.HeaderText = "CPF";
            this.categoriaColumn.Name = "categoriaColumn";
            this.categoriaColumn.ReadOnly = true;
            this.categoriaColumn.Width = 80;
            // 
            // valorColumn
            // 
            this.valorColumn.DataPropertyName = "RG";
            this.valorColumn.HeaderText = "RG";
            this.valorColumn.Name = "valorColumn";
            this.valorColumn.ReadOnly = true;
            // 
            // celularColumn
            // 
            this.celularColumn.DataPropertyName = "Celular";
            this.celularColumn.HeaderText = "Celular";
            this.celularColumn.Name = "celularColumn";
            this.celularColumn.ReadOnly = true;
            // 
            // PacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "PacientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idalasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularColumn;
    }
}