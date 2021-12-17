namespace aula01Ambev.Model
{
    public class Filial : ModelBase
    {
        public Filial()
        {
            endereco = new Endereco();
        }

        public Endereco endereco { get; set; }

        public void Atualizar(Endereco endereco)
        {
            this.endereco = endereco;
        }
    }
}