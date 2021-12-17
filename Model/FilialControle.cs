namespace aula01Ambev.Model
{
    public class FilialControle
    {
        private List<Filial> listaFilial { get; set; }

        public FilialControle() 
        {
            listaFilial = new List<Filial>();
        }

        public void CadastrarFilial(Filial filial) => listaFilial.Add(filial);

        public List<Filial> BuscarPorNome(string nome) => listaFilial.Where(x => x.endereco.nome.Equals(nome)).ToList();

        public Filial? BuscarPorId(int id) => listaFilial.Find(x => x.id == id);
    }
}