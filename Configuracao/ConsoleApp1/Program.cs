using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Naely Carvalho Taveira";
            usuario.NomeUsuario = "LeanCart";
            usuario.Ativo = true;
            usuario.Email = "nahtarveira@gmail.com";
            usuario.CPF = "073.486.341-17";
            usuario.Senha = "123";

            usuarioBLL.Inserir(usuario);
        }
    }
}