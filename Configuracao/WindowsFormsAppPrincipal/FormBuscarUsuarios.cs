using System;
using System.Windows.Forms;
using BLL;

namespace WindowsFormsAppPrincipal
{
    public partial class FormBuscarUsuarios : Form
    {
        public FormBuscarUsuarios()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            if(textBox1.Text == "")
            {
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else
            {
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorNomeUsuario(textBox1.Text);
            }
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }
    }
}
