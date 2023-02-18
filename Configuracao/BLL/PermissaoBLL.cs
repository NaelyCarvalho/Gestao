using Models;
using DAL;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            if (_permissao.Descricao.Length <= 30 || _permissao.Descricao.Length >= 250)
            {
                throw new Exception("A descrição deve ter entre 30 e 250 caracteres.");
            }

            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Inserir(_permissao);
        }

        public PermissaoBLL Buscar(string _nomeUsuario)
        {
            return new PermissaoBLL();
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
    }
}
