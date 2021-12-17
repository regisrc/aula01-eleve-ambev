using System;

namespace aula01Ambev.Model {
    public class Estoque : ModelBase {
        public int quantidadeEstoque { get; set; }

        public Produto produto { get; set; }

        public Estoque(Produto _produto)
        {
            this.produto = _produto;
        }

        public void Atualizar(int _quantidadeEstoque)
        {
            quantidadeEstoque = _quantidadeEstoque;
        }
    }
}
