using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8TrabalhoAgenda {
    public class Contato : Cadastro {
        protected string Tel { get; set; }
        protected string Email { get; set; }

        public Contato(string nome, string fone, string mail) {
            this.Nome = nome;
            this.Tel = fone;
            this.Email = mail;
        }

        public override string retornaDados() {
            string frase = this.Nome + " - " + this.Tel;
            return frase;
        }

        public override string retornaCompleto() {
            string fr = base.retornaCompleto();
            string frase = "Nome: " + fr + "\nTelefone: " + this.Tel + "\nE-mail: " + this.Email;
            return frase;
        }
    }
}
