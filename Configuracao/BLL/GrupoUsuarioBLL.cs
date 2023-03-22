using Models;
using DAL;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _GrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(6);
            if (_GrupoUsuario.NomeGrupo.Length <= 15 || _GrupoUsuario.NomeGrupo.Length >= 100)
            {
                throw new Exception("O nome do grupo do grupo deve ter entre 15 e 100 caracteres.");
            }

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Inserir(_GrupoUsuario);
        }

        public void Alterar(GrupoUsuario _GrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(7);

            if (_GrupoUsuario.NomeGrupo.Length <= 15 || _GrupoUsuario.NomeGrupo.Length >= 100)
            {
                throw new Exception("O nome do grupo do grupo deve ter entre 15 e 100 caracteres.");
            }

            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.ALterar(_GrupoUsuario);
        }

        public void Excluir(int _IdGrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(8);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            grupoUsuarioDAL.Excluir(_IdGrupoUsuario);
        }
        public GrupoUsuario BuscarPorID(int _idGrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(5);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarPorID(_idGrupoUsuario);
        }

        public List<GrupoUsuario> BuscarTodosGrupos()
        {
            new UsuarioBLL().ValidarPermissao(5);
            GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();
            return grupoUsuarioDAL.BuscarTodosGrupos();
        }

    }
}
