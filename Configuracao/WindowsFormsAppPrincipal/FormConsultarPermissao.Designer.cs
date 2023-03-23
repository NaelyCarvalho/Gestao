namespace WindowsFormsAppPrincipal
{
    partial class FormConsultarPermissao
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
            this.consultarPermissao = new System.Windows.Forms.Label();
            this.textBuscarpermissao = new System.Windows.Forms.TextBox();
            this.buttonBuscarpermissao = new System.Windows.Forms.Button();
            this.permissaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permissaoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonselecionar = new System.Windows.Forms.Button();
            this.buttoncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultarPermissao
            // 
            this.consultarPermissao.AutoSize = true;
            this.consultarPermissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultarPermissao.Location = new System.Drawing.Point(193, 9);
            this.consultarPermissao.Name = "consultarPermissao";
            this.consultarPermissao.Size = new System.Drawing.Size(340, 38);
            this.consultarPermissao.TabIndex = 5;
            this.consultarPermissao.Text = "Consultar Permissão";
            this.consultarPermissao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBuscarpermissao
            // 
            this.textBuscarpermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBuscarpermissao.Location = new System.Drawing.Point(64, 73);
            this.textBuscarpermissao.Name = "textBuscarpermissao";
            this.textBuscarpermissao.Size = new System.Drawing.Size(576, 22);
            this.textBuscarpermissao.TabIndex = 6;
            // 
            // buttonBuscarpermissao
            // 
            this.buttonBuscarpermissao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarpermissao.Location = new System.Drawing.Point(646, 73);
            this.buttonBuscarpermissao.Name = "buttonBuscarpermissao";
            this.buttonBuscarpermissao.Size = new System.Drawing.Size(80, 23);
            this.buttonBuscarpermissao.TabIndex = 7;
            this.buttonBuscarpermissao.Text = "Buscar";
            this.buttonBuscarpermissao.UseVisualStyleBackColor = true;
            this.buttonBuscarpermissao.Click += new System.EventHandler(this.buttonBuscarpermissao_Click);
            // 
            // permissaoBindingSource
            // 
            this.permissaoBindingSource.DataSource = typeof(Models.Permissao);
            // 
            // permissaoDataGridView
            // 
            this.permissaoDataGridView.AllowUserToAddRows = false;
            this.permissaoDataGridView.AllowUserToDeleteRows = false;
            this.permissaoDataGridView.AllowUserToOrderColumns = true;
            this.permissaoDataGridView.AutoGenerateColumns = false;
            this.permissaoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.permissaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permissaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.permissaoDataGridView.DataSource = this.permissaoBindingSource;
            this.permissaoDataGridView.Location = new System.Drawing.Point(64, 102);
            this.permissaoDataGridView.Name = "permissaoDataGridView";
            this.permissaoDataGridView.ReadOnly = true;
            this.permissaoDataGridView.RowHeadersWidth = 51;
            this.permissaoDataGridView.RowTemplate.Height = 24;
            this.permissaoDataGridView.Size = new System.Drawing.Size(662, 295);
            this.permissaoDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonselecionar
            // 
            this.buttonselecionar.Location = new System.Drawing.Point(521, 403);
            this.buttonselecionar.Name = "buttonselecionar";
            this.buttonselecionar.Size = new System.Drawing.Size(86, 24);
            this.buttonselecionar.TabIndex = 9;
            this.buttonselecionar.Text = "Selecionar";
            this.buttonselecionar.UseVisualStyleBackColor = true;
            this.buttonselecionar.Click += new System.EventHandler(this.buttonselecionar_Click);
            // 
            // buttoncancelar
            // 
            this.buttoncancelar.Location = new System.Drawing.Point(628, 403);
            this.buttoncancelar.Name = "buttoncancelar";
            this.buttoncancelar.Size = new System.Drawing.Size(75, 23);
            this.buttoncancelar.TabIndex = 10;
            this.buttoncancelar.Text = "Cancelar";
            this.buttoncancelar.UseVisualStyleBackColor = true;
            this.buttoncancelar.Click += new System.EventHandler(this.buttoncancelar_Click);
            // 
            // FormConsultarPermissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncancelar);
            this.Controls.Add(this.buttonselecionar);
            this.Controls.Add(this.permissaoDataGridView);
            this.Controls.Add(this.buttonBuscarpermissao);
            this.Controls.Add(this.textBuscarpermissao);
            this.Controls.Add(this.consultarPermissao);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormConsultarPermissao";
            this.ShowIcon = false;
            this.Text = "FormConsultarPermissao";
            ((System.ComponentModel.ISupportInitialize)(this.permissaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permissaoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label consultarPermissao;
        private System.Windows.Forms.TextBox textBuscarpermissao;
        private System.Windows.Forms.Button buttonBuscarpermissao;
        private System.Windows.Forms.BindingSource permissaoBindingSource;
        private System.Windows.Forms.DataGridView permissaoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonselecionar;
        private System.Windows.Forms.Button buttoncancelar;
    }
}