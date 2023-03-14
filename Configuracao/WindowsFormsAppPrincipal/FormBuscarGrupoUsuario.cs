using BLL;
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

    }
}
