using System;

namespace aula01Ambev.Model {
    public class EstoqueControle {
        private List<Estoque> listaEstoque { get; set; }

        public EstoqueControle()
        {
            listaEstoque = new List<Estoque>();
        }

        public void Cadastrar(Estoque estoque) => listaEstoque.Add(estoque);

        private Estoque? BuscarPorIdProduto(int id) => listaEstoque.Find(x => x.produto.id == id);

        public bool DiminuirEstoque(int id, int quantidade) 
        {
            var result = BuscarPorIdProduto(id);

            if (result == null || result.quantidadeEstoque < quantidade)
                return false;

            result.Atualizar(result.quantidadeEstoque - quantidade);

            return true;
        }
    }
}
