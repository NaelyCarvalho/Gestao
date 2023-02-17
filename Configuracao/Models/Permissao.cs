
namespace Models
{
    public class Permissao
    {
        public int IdDescricao { get; set; } 
        public string Descricao { get; set; }
        public List<GrupoUsuario> GrupoUsuarios { get; set; }

    }
}
