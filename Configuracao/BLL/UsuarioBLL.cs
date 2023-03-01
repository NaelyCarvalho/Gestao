using Models;
using DAL;

namespace BLL
{
    public class UsuarioBLL
    {
        private static void ValidarDados(Usuario _usuario)
        {
            //Todo: Validar se a senha é maior que 50 ou menor que 3 e se contém espaço
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
            {
                throw new Exception("O nome de usuário deve ter entre 3 e 50 caracteres.");
                if (_usuario.NomeUsuario.Contains(" "))
                {
                    throw new Exception("O nome de usuário não pode conter espaços.");
                }
            }
            //Todo: Validar se a senha é maior que 11 ou menor que 7
            if (_usuario.Senha.Length < 7 || _usuario.Senha.Length > 11)
            {
                throw new Exception("A senha deve ter entre 7 e 12 caracteres.");
            }

            //Todo: Validar se a senha não é 1234
            if (_usuario.Senha.Contains("1234567"))
            {
                throw new Exception("Não é permitido números em sequência.");
            }
        }
        public void Inserir(Usuario _usuario)
        {

            //Todo: Validar se já existe um usuário com este nome.
            ValidarDados(_usuario);

            Usuario usuario = new Usuario();
            usuario = BuscarPorNomeUsuario(_usuario.NomeUsuario);
            if (usuario.NomeUsuario == _usuario.NomeUsuario)
            {
                throw new Exception("Já existe um usuário com este nome");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
        }

        public void Alterar(Usuario _usuario)
        {
            ValidarDados(_usuario);
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Alterar(_usuario);
        }

        public void Excluir(int _id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Excluir(_id);
        }

        public List<Usuario> BuscarTodos()
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarTodos();
        }

        public Usuario BuscarPorNomeUsuario(string _nomeUsuario)
        {
            if (String.IsNullOrEmpty(_nomeUsuario))
            {
                throw new Exception("Informe o nome do usuário.");
            }

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.BuscarPorNomeUsuario(_nomeUsuario);
        }
    }
}