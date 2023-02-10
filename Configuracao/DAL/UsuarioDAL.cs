using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();


            }
            catch (Exception)
            {
            }
            finally
            {
                cn.Close();
            }
        }

        public Usuario Buscar(string _NomeUSuario)
        {
            return new Usuario();
        }
        public void ALterar(Usuario _usuario)
        {

        }

        public void Excluir(int _id)
        {

        }
       
    }
}