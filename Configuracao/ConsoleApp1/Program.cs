using BLL;
using DAL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                GrupoUsuario grupoUsuario = new GrupoUsuario();
                GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();

                Console.WriteLine("Digite o IdDescrição da linha que quer excluir: ");
                grupoUsuario.IdGrupoUsuario = Convert.ToInt32(Console.ReadLine());

                grupoUsuarioBLL.Excluir(grupoUsuario.IdGrupoUsuario);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}