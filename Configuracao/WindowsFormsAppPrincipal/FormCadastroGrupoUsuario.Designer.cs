namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroGrupoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeGrupoLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.nomeGrupoTextBox = new System.Windows.Forms.TextBox();
            this.grupoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelargrupo = new System.Windows.Forms.Button();
            this.salvargrupo = new System.Windows.Forms.Button();
            nomeGrupoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeGrupoLabel.Location = new System.Drawing.Point(73, 88);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new System.Drawing.Size(128, 20);
            nomeGrupoLabel.TabIndex = 4;
            nomeGrupoLabel.Text = "Nome do grupo:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Grupos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nomeGrupoTextBox
            // 
            this.nomeGrupoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nomeGrupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoUsuarioBindingSource, "NomeGrupo", true));
            this.nomeGrupoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeGrupoTextBox.Location = new System.Drawing.Point(222, 83);
            this.nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            this.nomeGrupoTextBox.Size = new System.Drawing.Size(252, 28);
            this.nomeGrupoTextBox.TabIndex = 5;
            // 
            // grupoUsuarioBindingSource
            // 
            this.grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // cancelargrupo
            // 
            this.cancelargrupo.Location = new System.Drawing.Point(376, 147);
            this.cancelargrupo.Name = "cancelargrupo";
            this.cancelargrupo.Size = new System.Drawing.Size(75, 23);
            this.cancelargrupo.TabIndex = 6;
            this.cancelargrupo.Text = "Cancelar";
            this.cancelargrupo.UseVisualStyleBackColor = true;
            this.cancelargrupo.Click += new System.EventHandler(this.cancelargrupo_Click);
            // 
            // salvargrupo
            // 
            this.salvargrupo.Location = new System.Drawing.Point(295, 147);
            this.salvargrupo.Name = "salvargrupo";
            this.salvargrupo.Size = new System.Drawing.Size(75, 23);
            this.salvargrupo.TabIndex = 7;
            this.salvargrupo.Text = "Salvar";
            this.salvargrupo.UseVisualStyleBackColor = true;
            this.salvargrupo.Click += new System.EventHandler(this.salvargrupo_Click);
            // 
            // FormCadastroGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 214);
            this.Controls.Add(this.salvargrupo);
            this.Controls.Add(this.cancelargrupo);
            this.Controls.Add(nomeGrupoLabel);
            this.Controls.Add(this.nomeGrupoTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(552, 261);
            this.MinimumSize = new System.Drawing.Size(552, 261);
            this.Name = "FormCadastroGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroGrupoUsuario";
            this.Load += new System.EventHandler(this.FormCadastroGrupoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button cancelargrupo;
        private System.Windows.Forms.Button salvargrupo;
    }
}