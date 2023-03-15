﻿using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroUsuario : Form
    {
        private bool alterar;
        public FormCadastroUsuario(bool _alterar = false, int _id = 0)
        {
            InitializeComponent();
            alterar = _alterar;

            if (alterar)
            {
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorIdUsuario(_id);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            try
            {
                usuarioBindingSource.EndEdit();
                if (!alterar)
                {
                    usuarioBLL.Inserir((Usuario)usuarioBindingSource.Current, ConfirmacaoTextBox.Text);
                }
                else
                {
                    usuarioBLL.Alterar((Usuario)usuarioBindingSource.Current, ConfirmacaoTextBox.Text);
                }
                MessageBox.Show("Registro Salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            if (!alterar)
            {
                usuarioBindingSource.AddNew();
            }
            
        }
    }
}
