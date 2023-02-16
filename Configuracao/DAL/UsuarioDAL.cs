
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
                cmd.Connection = cn;
                cmd.CommandText = @"Insert into Usuario(Nome, NomeUsuario, CPF, Email, Senha, Ativo) 
                                    Values(@Nome,@NomeUsuario,@CPF,@Email,@Senha,@Ativo)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);

                cn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco de dados: " + ex.Message);
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