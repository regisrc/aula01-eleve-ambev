using System;

namespace aula01Ambev.Model {
    public class ProdutoControle {
        private List<Produto> listaProduto { get; set; }

        public ProdutoControle()
        {
            listaProduto = new List<Produto>();
        }

        public void CadastrarProduto(Produto produto) => listaProduto.Add(produto);

        public void DeletarProduto(Produto produto) => listaProduto.Remove(produto);
        
        public Produto? BuscarPorId(int id) => listaProduto.Find(x => x.id == id);
    }
}