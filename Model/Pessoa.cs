using System;

namespace aula01Ambev.Model {
    public class Pessoa : ModelBase {
        public string nome { get; set; }
        public string nomeSocial { get; set; }
        public string documento { get; set; }
        public Endereco endereco { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }

        public virtual void VerificaDocumento(string _documento) { }

        public virtual void Atualizar(string _nome, string _nomeSocial, string _documento, Endereco _endereco, string _telefone, string _email) { } 
    }
}
