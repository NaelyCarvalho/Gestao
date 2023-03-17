using BLL;
using Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarGrupoUsuario : Form
    {
        public FormBuscarGrupoUsuario()
        {
            InitializeComponent();
        }

        private void buttonBuscarGrupo_Click_1(object sender, EventArgs e)
        {
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            if (textboxgrupo.Text == "")
            {
                grupoUsuariosBindingSource.DataSource = grupoUsuarioBLL.BuscarTodosGrupos();
            }
            else
            {
                grupoUsuariosBindingSource.DataSource = grupoUsuarioBLL.BuscarPorID(Convert.ToInt32(textboxgrupo.Text));
            }

        }

        private void buttonAdicionarGrupo_Click(object sender, EventArgs e)
        {
            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterarGrupo_Click(object sender, EventArgs e)
        {
            int IdGrupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).IdGrupoUsuario;

            using (FormCadastroGrupoUsuario frm = new FormCadastroGrupoUsuario(true, IdGrupo))
            {
                frm.ShowDialog();
            }

            buttonBuscarGrupo_Click_1(sender, e);
        }

        private void buttonExcluirGrupo_Click(object sender, EventArgs e)
        {
            if (grupoUsuariosBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro? ", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int Idgrupo = ((GrupoUsuario)grupoUsuariosBindingSource.Current).IdGrupoUsuario;
            new GrupoUsuarioBLL().Excluir(Idgrupo);

            MessageBox.Show("Registro excluído com sucesso!");
            buttonBuscarGrupo_Click_1(null, null);
        }
    }
}
