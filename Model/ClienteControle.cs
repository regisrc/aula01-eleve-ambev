using System;
using System.Collections.Generic;

namespace aula01Ambev.Model
{
    public class ClienteControle { 
        private List<Pessoa> listaClientesPf { get; set; }

        private List<Pessoa> listaClientesPj { get; set; }

        public ClienteControle() 
        {
            listaClientesPf = new List<Pessoa>();

            listaClientesPj = new List<Pessoa>();
        }

        public void CadastrarCliente(Pessoa pessoa) 
        {
            if (IsClientePf(pessoa.documento))
                listaClientesPf.Add(pessoa);
            else if (IsClientePj(pessoa.documento))
                listaClientesPj.Add(pessoa);
        }

        private bool IsClientePf(string documento) => documento.Length == 11;

        private bool IsClientePj(string documento) => documento.Length == 14;

        public List<Pessoa> BuscarPorNome(string nome)
        {
            var result = JuntaLista();

            return result.Where(x => x.nome.Equals(nome)).ToList();
        }

        public Pessoa? BuscarPorId(int id) 
        {
            var result = JuntaLista();

            return result.Find(x => x.id == id);
        }

        private List<Pessoa> JuntaLista()
        {
            var result = listaClientesPf;

            result.AddRange(listaClientesPj);

            return result;
        }
    }   
}