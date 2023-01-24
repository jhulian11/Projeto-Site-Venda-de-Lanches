namespace LanchesMac.Models
{
    public class Categoria
    {
        public int  Id { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }

        public Categoria()
        {
            Lanches = new List<Lanche>();
        }
    }
}
