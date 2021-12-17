using System;

namespace aula01Ambev.Model {
    public class Estoque {
        public int id { get; set; }
        public int nome { get; set; }
        public string nomeSocial { get; set; }

        public virtual void VerificaDocumento(string _documento) { }
    }
}
