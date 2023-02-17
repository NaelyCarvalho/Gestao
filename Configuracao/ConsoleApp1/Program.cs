using BLL;
using DAL;
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
                Permissao permissao = new Permissao();
                PermissaoBLL permissaoBLL = new PermissaoBLL();
                do
                {
                    Console.WriteLine("Descrição: ");
                    permissao.Descricao = Console.ReadLine();

                    permissaoBLL.Inserir(permissao);

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