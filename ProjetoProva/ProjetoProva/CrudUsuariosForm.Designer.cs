namespace ProjetoProva
{
    partial class CrudUsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudUsuariosForm));
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.senhaLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.fecharButton = new System.Windows.Forms.Button();
            this.salvarButton = new System.Windows.Forms.Button();
            this.acessaUsuarioCheckBox = new System.Windows.Forms.CheckBox();
            this.acessaInternadoscheckBox = new System.Windows.Forms.CheckBox();
            this.acessaMedcheckBox = new System.Windows.Forms.CheckBox();
            this.ativoCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(36, 199);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(277, 20);
            this.senhaTextBox.TabIndex = 17;
            // 
            // senhaLabel
            // 
            this.senhaLabel.AutoSize = true;
            this.senhaLabel.Location = new System.Drawing.Point(33, 182);
            this.senhaLabel.Name = "senhaLabel";
            this.senhaLabel.Size = new System.Drawing.Size(38, 13);
            this.senhaLabel.TabIndex = 16;
            this.senhaLabel.Text = "Senha";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(36, 146);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(277, 20);
            this.emailTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(33, 129);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "E-mail";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(36, 97);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(277, 20);
            this.nomeTextBox.TabIndex = 13;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(33, 80);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 12;
            this.nomeLabel.Text = "Nome";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(36, 44);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(277, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(33, 27);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "ID";
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(446, 258);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(75, 23);
            this.fecharButton.TabIndex = 27;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            this.fecharButton.Click += new System.EventHandler(this.fecharButton_Click);
            // 
            // salvarButton
            // 
            this.salvarButton.Location = new System.Drawing.Point(351, 258);
            this.salvarButton.Name = "salvarButton";
            this.salvarButton.Size = new System.Drawing.Size(75, 23);
            this.salvarButton.TabIndex = 26;
            this.salvarButton.Text = "Salvar";
            this.salvarButton.UseVisualStyleBackColor = true;
            this.salvarButton.Click += new System.EventHandler(this.salvarButton_Click);
            // 
            // acessaUsuarioCheckBox
            // 
            this.acessaUsuarioCheckBox.AutoSize = true;
            this.acessaUsuarioCheckBox.Location = new System.Drawing.Point(390, 44);
            this.acessaUsuarioCheckBox.Name = "acessaUsuarioCheckBox";
            this.acessaUsuarioCheckBox.Size = new System.Drawing.Size(105, 17);
            this.acessaUsuarioCheckBox.TabIndex = 28;
            this.acessaUsuarioCheckBox.Text = "Acessa Usuários";
            this.acessaUsuarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // acessaInternadoscheckBox
            // 
            this.acessaInternadoscheckBox.AutoSize = true;
            this.acessaInternadoscheckBox.Location = new System.Drawing.Point(390, 99);
            this.acessaInternadoscheckBox.Name = "acessaInternadoscheckBox";
            this.acessaInternadoscheckBox.Size = new System.Drawing.Size(114, 17);
            this.acessaInternadoscheckBox.TabIndex = 29;
            this.acessaInternadoscheckBox.Text = "Acessa Internados";
            this.acessaInternadoscheckBox.UseVisualStyleBackColor = true;
            // 
            // acessaMedcheckBox
            // 
            this.acessaMedcheckBox.AutoSize = true;
            this.acessaMedcheckBox.Location = new System.Drawing.Point(390, 149);
            this.acessaMedcheckBox.Name = "acessaMedcheckBox";
            this.acessaMedcheckBox.Size = new System.Drawing.Size(133, 17);
            this.acessaMedcheckBox.TabIndex = 30;
            this.acessaMedcheckBox.Text = "Acessa Medicamentos";
            this.acessaMedcheckBox.UseVisualStyleBackColor = true;
            // 
            // ativoCheckBox
            // 
            this.ativoCheckBox.AutoSize = true;
            this.ativoCheckBox.Location = new System.Drawing.Point(390, 201);
            this.ativoCheckBox.Name = "ativoCheckBox";
            this.ativoCheckBox.Size = new System.Drawing.Size(50, 17);
            this.ativoCheckBox.TabIndex = 31;
            this.ativoCheckBox.Text = "Ativo";
            this.ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // CrudUsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 311);
            this.Controls.Add(this.ativoCheckBox);
            this.Controls.Add(this.acessaMedcheckBox);
            this.Controls.Add(this.acessaInternadoscheckBox);
            this.Controls.Add(this.acessaUsuarioCheckBox);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.salvarButton);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.senhaLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrudUsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro/Alteração Usuários";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Label senhaLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.Button salvarButton;
        private System.Windows.Forms.CheckBox acessaUsuarioCheckBox;
        private System.Windows.Forms.CheckBox acessaInternadoscheckBox;
        private System.Windows.Forms.CheckBox acessaMedcheckBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
    }
}