using System;

namespace aula01Ambev.Model {
    public class VendaControle {
        private List<Venda> listaVenda { get; set; }

        public VendaControle()
        {
            listaVenda = new List<Venda>();
        }

        public void CadastrarVenda(Venda venda, EstoqueControle estoqueControle) 
        { 
            var result = estoqueControle.DiminuirEstoque(venda.produto.id, venda.quantidade);

            if (result)
                listaVenda.Add(venda);
        }

        public Venda? BuscarPorId(int id) => listaVenda.Find(x => x.id == id);

        public Venda? BuscarPorIdCliente(int id) => listaVenda.Find(x => x.pessoa?.id == id);
    }
}