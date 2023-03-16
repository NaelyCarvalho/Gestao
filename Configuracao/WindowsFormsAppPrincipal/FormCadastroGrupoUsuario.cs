using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormCadastroGrupoUsuario : Form
    {
        private bool alterarGrupo;
        public FormCadastroGrupoUsuario(bool _alterar = false, int _idGrupo = 0)
        {
            InitializeComponent();
            alterarGrupo = _alterar;

            if (alterarGrupo)
            {
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
                grupoUsuarioBindingSource.DataSource = grupoUsuarioBLL.BuscarPorID(_idGrupo);
            }
        }

        private void cancelargrupo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salvargrupo_Click(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();

            try
            {
                grupoUsuarioBindingSource.EndEdit();
                if (!alterarGrupo)
                {
                    grupoUsuarioBLL.Inserir((GrupoUsuario)grupoUsuarioBindingSource.Current);
                }
                else
                {
                    grupoUsuarioBLL.Alterar((GrupoUsuario)grupoUsuarioBindingSource.Current);
                }
                MessageBox.Show("Registro Salvo com sucesso!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroGrupoUsuario_Load(object sender, EventArgs e)
        {
            if (!alterarGrupo)
            {
                grupoUsuarioBindingSource.AddNew();
            }
        }

    }
}
