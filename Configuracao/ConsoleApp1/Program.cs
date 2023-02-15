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
                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();
                do
                {
                    usuario.Nome = "Matheus França";
                    usuario.NomeUsuario = "Matheus123";
                    usuario.Ativo = true;
                    usuario.Email = "matheusfranca@gmail.com";
                    usuario.CPF = "073.486.341-17";
                    usuario.Senha = "5024598";
                    usuarioBLL.Inserir(usuario);
                    usuarioBLL.Exibir(usuario);

                       Console.WriteLine("Deseja adicionar mais um usuário: Digite (1) para SIM e (2) para NÃO.");
                      questao = Convert.ToInt32(Console.ReadLine());

                       } while(questao==1);

                }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}