using System;

namespace aula01Ambev.Model
{
    public class ClientePj : Pessoa {
        public override void VerificaDocumento(string _documento) {
            if(_documento.Length == 14) {
                documento = _documento;
            }
        }

        public override void Atualizar(string _nome, string _nomeSocial, string _documento, Endereco _endereco, string _telefone, string _email) 
        {
            nome = _nome;
            nomeSocial = _nomeSocial;
            VerificaDocumento(_documento);
            endereco = _endereco;
            telefone = _telefone;
            email = _email;
        } 
    }   
}