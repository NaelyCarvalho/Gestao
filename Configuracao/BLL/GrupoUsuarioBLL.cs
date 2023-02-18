using Models;
using DAL;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _GrupoUsuario)
        {
            if (_GrupoUsuario.NomeGrupo.Length <= 15 || _GrupoUsuario.NomeGrupo.Length >= 100)
            {
                throw new Exception("O nome do grupo do grupo deve ter entre 15 e 100 caracteres.");
            }

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_GrupoUsuario);
        }

        public void Alterar(GrupoUsuario _GrupoUsuario)
        {
            if (_GrupoUsuario.NomeGrupo.Length <= 15 || _GrupoUsuario.NomeGrupo.Length >= 100)
            {
                throw new Exception("O nome do grupo do grupo deve ter entre 15 e 100 caracteres.");
            }

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.ALterar(_GrupoUsuario);
        }

        public GrupoUsuario Buscar(int _IdGrupoUsuario)
        {
            return new GrupoUsuario();
        }

        public void Excluir(int _IdGrupoUsuario)
        {
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Excluir(_IdGrupoUsuario);
        }
    }
}
