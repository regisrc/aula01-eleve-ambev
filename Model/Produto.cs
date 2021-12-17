using System;

namespace aula01Ambev.Model {
    public class Produto : ModelBase {
        public string nome { get; set; }

        public double valor { get; set; }

        public void Atualizar(string _nome, double _valor)
        {
            nome = _nome;
            valor = _valor;
        }
    }
}