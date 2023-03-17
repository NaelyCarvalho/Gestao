using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using BLL;
using Models;

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
            if (textBox1.Text == "")
            {
                usuarioBindingSource.DataSource = usuarioBLL.BuscarTodos();
            }
            else
            {
                usuarioBindingSource.DataSource = usuarioBLL.BuscarPorIdUsuario(Convert.ToInt32(textBox1.Text));
            }
        }

        private void buttonAdicionarUsuario_Click(object sender, EventArgs e)
        {
            using (FormCadastroUsuario frm = new FormCadastroUsuario())
            {
                frm.ShowDialog();
            }

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Usuario)usuarioBindingSource.Current).Id;

            using (FormCadastroUsuario frm = new FormCadastroUsuario(true, id))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click(sender, e);
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (usuarioBindingSource.Count <= 0)
            {
                MessageBox.Show("Não existe registro para ser excluído.");
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este registro? ", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
         
            int id = ((Usuario)usuarioBindingSource.Current).Id;
            new UsuarioBLL().Excluir(id);

            MessageBox.Show("Registro excluído com sucesso!");
            buttonBuscar_Click(null, null);
        }

        private void buttonAdicionarGrupoUsuario_Click(object sender, EventArgs e)
        {
            using (FormConsultarGrupoUsuario frm = new FormConsultarGrupoUsuario())
            {
                frm.ShowDialog();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                int Id = ((Usuario)usuarioBindingSource.Current).Id;
                usuarioBLL.AdicionarGrupo(Id, frm.Id);
            }
        }
    }
}
