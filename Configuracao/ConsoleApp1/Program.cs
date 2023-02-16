using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int questao;

            try
            {
                string opcao;
                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                do
                {
                    Console.WriteLine("Nome: ");
                    usuario.Nome = Console.ReadLine();

                    Console.WriteLine("Nome de Usuario: ");
                    usuario.NomeUsuario = Console.ReadLine();

                    Console.WriteLine("Email: ");
                    usuario.Email = Console.ReadLine();

                    Console.WriteLine("CPF: ");
                    usuario.CPF = Console.ReadLine();

                    Console.WriteLine("Senha: ");
                    usuario.Senha = Console.ReadLine();

                    Console.WriteLine("O usuário estará ativo (S) para sim ou (N) para não : ");
                    usuario.Ativo = Console.ReadLine().ToUpper() == "S";

                    usuarioBLL.Inserir(usuario);


                    Console.WriteLine("Deseja adicionar mais um usuário: Digite (1) para SIM e (2) para NÃO.");
                    questao = Convert.ToInt32(Console.ReadLine());

                } while (questao == 1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}