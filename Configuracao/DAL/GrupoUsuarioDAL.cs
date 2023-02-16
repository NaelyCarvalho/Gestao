using Models;
using System.Data.SqlClient;

namespace DAL
{
    internal class GrupoUsuarioDAL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into GrupoUsuario(NomeGrupo)
                                    Values(@NomeGrupo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("NomeGrupo", _grupoUsuario.NomeGrupo);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um grupo de usuários no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public GrupoUsuario Buscar(int _idGrupoUsuario)
        {
            return new GrupoUsuario();
        }

        public void ALterar(GrupoUsuario _GrupoUsuario)
        {

        }

        public void Excluir(int _idGrupoUsuario)
        {

        }

    }
}
