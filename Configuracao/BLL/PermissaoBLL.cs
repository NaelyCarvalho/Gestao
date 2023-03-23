using Models;
using DAL;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(int _idPermisao, int _idGrupoUsuario)
        {
            new UsuarioBLL().ValidarPermissao(9);
            if (new PermissaoDAL().ExisteRelacionamento(_idPermisao, _idGrupoUsuario))
            {
                throw new Exception("A descrição já está vinculada.");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_idPermisao, _idGrupoUsuario);
        }

        public void Alterar(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 30 || _permissao.Descricao.Length >= 250)
            {
                throw new Exception("A descrição deve ter entre 30 e 250 caracteres.");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Alterar(_permissao);
        }

        public void Excluir(int _IdDescricao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_IdDescricao);
        }

        public List<Permissao> BuscarPorIDDescricao(int _IdDescricao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPorIDDescricao(_IdDescricao);
        }

    }
}
