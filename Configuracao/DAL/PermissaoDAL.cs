
using Models;
using System.Data.SqlClient;

namespace DAL
{
    internal class PermissaoDAL
    {
        public void Inserir(Permissao _permissao)
        {
            SqlConnection cn = new SqlConnection();

            try
            {
                cn.ConnectionString = Conexao.StringDeConexao;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into Permissao(Descricao)
                                  Values(@Descricao)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Descricao", _permissao.Descricao);

                cn.Open();
                cmd.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma permissão no banco de dados: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public Permissao Buscar(int _idDescricao)
        {
            return new Permissao();
        }

        public void ALterar(Permissao _permissao)
        {

        }

        public void Excluir(int _idDescricao)
        {

        }
    }
}
