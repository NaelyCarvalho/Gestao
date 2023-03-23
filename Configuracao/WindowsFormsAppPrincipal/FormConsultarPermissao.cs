using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultarPermissao : Form
    {
        public int Id;
        public FormConsultarPermissao()
        {
            InitializeComponent();
        }

        private void buttonBuscarpermissao_Click(object sender, EventArgs e)
        {
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            try
            {
                permissaoBindingSource.DataSource = permissaoBLL.BuscarPorIDDescricao(Convert.ToInt32(buttonBuscarpermissao.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonselecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (permissaoBindingSource.Count > 0)
                {
                    Id = ((Permissao)permissaoBindingSource.Current).IdDescricao;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
