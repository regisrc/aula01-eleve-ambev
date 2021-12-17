namespace aula01Ambev.Model
{
    public class Venda : ModelBase
    {
        public Venda()
        {
            produto = new Produto();
        }

        public Produto produto { get; set; }

        public Pessoa? pessoa { get; set; }

        public int quantidade { get; set; }
    }
}