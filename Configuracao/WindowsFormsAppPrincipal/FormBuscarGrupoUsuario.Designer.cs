namespace WindowsFormsAppPrincipal
{
    partial class FormBuscarGrupoUsuario
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
            this.grupoUsuariosDataGridView = new System.Windows.Forms.DataGridView();
            this.textboxgrupo = new System.Windows.Forms.TextBox();
            this.buttonBuscarGrupo = new System.Windows.Forms.Button();
            this.buttonExcluirGrupo = new System.Windows.Forms.Button();
            this.buttonAdicionarGrupo = new System.Windows.Forms.Button();
            this.buttonAlterarGrupo = new System.Windows.Forms.Button();
            this.permissoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdicionarPermissao = new System.Windows.Forms.Button();
            this.ExcluirPermissao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoUsuariosDataGridView
            // 
            this.grupoUsuariosDataGridView.AllowUserToAddRows = false;
            this.grupoUsuariosDataGridView.AllowUserToDeleteRows = false;
            this.grupoUsuariosDataGridView.AllowUserToOrderColumns = true;
            this.grupoUsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grupoUsuariosDataGridView.AutoGenerateColumns = false;
            this.grupoUsuariosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grupoUsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grupoUsuariosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.grupoUsuariosDataGridView.DataSource = this.grupoUsuariosBindingSource;
            this.grupoUsuariosDataGridView.Location = new System.Drawing.Point(12, 86);
            this.grupoUsuariosDataGridView.Name = "grupoUsuariosDataGridView";
            this.grupoUsuariosDataGridView.ReadOnly = true;
            this.grupoUsuariosDataGridView.RowHeadersWidth = 51;
            this.grupoUsuariosDataGridView.RowTemplate.Height = 24;
            this.grupoUsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grupoUsuariosDataGridView.Size = new System.Drawing.Size(816, 374);
            this.grupoUsuariosDataGridView.TabIndex = 1;
            // 
            // textboxgrupo
            // 
            this.textboxgrupo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxgrupo.Location = new System.Drawing.Point(12, 46);
            this.textboxgrupo.Name = "textboxgrupo";
            this.textboxgrupo.Size = new System.Drawing.Size(454, 22);
            this.textboxgrupo.TabIndex = 4;
            // 
            // buttonBuscarGrupo
            // 
            this.buttonBuscarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarGrupo.Location = new System.Drawing.Point(472, 39);
            this.buttonBuscarGrupo.Name = "buttonBuscarGrupo";
            this.buttonBuscarGrupo.Size = new System.Drawing.Size(75, 33);
            this.buttonBuscarGrupo.TabIndex = 5;
            this.buttonBuscarGrupo.Text = "Buscar";
            this.buttonBuscarGrupo.UseVisualStyleBackColor = true;
            this.buttonBuscarGrupo.Click += new System.EventHandler(this.buttonBuscarGrupo_Click_1);
            // 
            // buttonExcluirGrupo
            // 
            this.buttonExcluirGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirGrupo.Location = new System.Drawing.Point(753, 40);
            this.buttonExcluirGrupo.Name = "buttonExcluirGrupo";
            this.buttonExcluirGrupo.Size = new System.Drawing.Size(75, 32);
            this.buttonExcluirGrupo.TabIndex = 6;
            this.buttonExcluirGrupo.Text = "Excluir";
            this.buttonExcluirGrupo.UseVisualStyleBackColor = true;
            this.buttonExcluirGrupo.Click += new System.EventHandler(this.buttonExcluirGrupo_Click);
            // 
            // buttonAdicionarGrupo
            // 
            this.buttonAdicionarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarGrupo.Location = new System.Drawing.Point(672, 41);
            this.buttonAdicionarGrupo.Name = "buttonAdicionarGrupo";
            this.buttonAdicionarGrupo.Size = new System.Drawing.Size(75, 32);
            this.buttonAdicionarGrupo.TabIndex = 7;
            this.buttonAdicionarGrupo.Text = "Adicionar";
            this.buttonAdicionarGrupo.UseVisualStyleBackColor = true;
            this.buttonAdicionarGrupo.Click += new System.EventHandler(this.buttonAdicionarGrupo_Click);
            // 
            // buttonAlterarGrupo
            // 
            this.buttonAlterarGrupo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarGrupo.Location = new System.Drawing.Point(591, 39);
            this.buttonAlterarGrupo.Name = "buttonAlterarGrupo";
            this.buttonAlterarGrupo.Size = new System.Drawing.Size(75, 33);
            this.buttonAlterarGrupo.TabIndex = 8;
            this.buttonAlterarGrupo.Text = "Alterar";
            this.buttonAlterarGrupo.UseVisualStyleBackColor = true;
            this.buttonAlterarGrupo.Click += new System.EventHandler(this.buttonAlterarGrupo_Click);
            // 
            // permissoesDataGridView
            // 
            this.permissoesDataGridView.AllowUserToAddRows = false;
            this.permissoesDataGridView.AllowUserToDeleteRows = false;
            this.permissoesDataGridView.AllowUserToOrderColumns = true;
            this.permissoesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.permissoesDataGridView.AutoGenerateColumns = false;
            this.permissoesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.permissoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.permissoesDataGridView.DataSource = this.permissoesBindingSource;
            this.permissoesDataGridView.Location = new System.Drawing.Point(834, 86);
            this.permissoesDataGridView.Name = "permissoesDataGridView";
            this.permissoesDataGridView.ReadOnly = true;
            this.permissoesDataGridView.RowHeadersWidth = 51;
            this.permissoesDataGridView.RowTemplate.Height = 24;
            this.permissoesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.permissoesDataGridView.Size = new System.Drawing.Size(512, 374);
            this.permissoesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // permissoesBindingSource
            // 
            this.permissoesBindingSource.DataMember = "Permissoes";
            this.permissoesBindingSource.DataSource = this.grupoUsuariosBindingSource;
            // 
            // grupoUsuariosBindingSource
            // 
            this.grupoUsuariosBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdGrupoUsuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID do Grupo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Grupo";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // AdicionarPermissao
            // 
            this.AdicionarPermissao.Location = new System.Drawing.Point(1185, 41);
            this.AdicionarPermissao.Name = "AdicionarPermissao";
            this.AdicionarPermissao.Size = new System.Drawing.Size(75, 31);
            this.AdicionarPermissao.TabIndex = 9;
            this.AdicionarPermissao.Text = "Adicionar";
            this.AdicionarPermissao.UseVisualStyleBackColor = true;
            this.AdicionarPermissao.Click += new System.EventHandler(this.AdicionarPermissao_Click);
            // 
            // ExcluirPermissao
            // 
            this.ExcluirPermissao.Location = new System.Drawing.Point(1266, 40);
            this.ExcluirPermissao.Name = "ExcluirPermissao";
            this.ExcluirPermissao.Size = new System.Drawing.Size(75, 32);
            this.ExcluirPermissao.TabIndex = 10;
            this.ExcluirPermissao.Text = "Excluir";
            this.ExcluirPermissao.UseVisualStyleBackColor = true;
            // 
            // FormBuscarGrupoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1374, 472);
            this.Controls.Add(this.ExcluirPermissao);
            this.Controls.Add(this.AdicionarPermissao);
            this.Controls.Add(this.permissoesDataGridView);
            this.Controls.Add(this.buttonExcluirGrupo);
            this.Controls.Add(this.buttonAdicionarGrupo);
            this.Controls.Add(this.buttonAlterarGrupo);
            this.Controls.Add(this.buttonBuscarGrupo);
            this.Controls.Add(this.textboxgrupo);
            this.Controls.Add(this.grupoUsuariosDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1392, 519);
            this.Name = "FormBuscarGrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GrupoUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuariosBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuariosDataGridView;
        private System.Windows.Forms.TextBox textboxgrupo;
        private System.Windows.Forms.Button buttonBuscarGrupo;
        private System.Windows.Forms.Button buttonExcluirGrupo;
        private System.Windows.Forms.Button buttonAdicionarGrupo;
        private System.Windows.Forms.Button buttonAlterarGrupo;
        private System.Windows.Forms.BindingSource permissoesBindingSource;
        private System.Windows.Forms.DataGridView permissoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button AdicionarPermissao;
        private System.Windows.Forms.Button ExcluirPermissao;
    }
}