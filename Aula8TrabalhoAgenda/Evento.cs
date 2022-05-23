using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8TrabalhoAgenda {
    public class Evento : Cadastro {
        protected string Data { get; set; }
        protected string Descricao { get; set; }
        public Contato contato { get; set; } 

        public Evento(string nome, string data, Contato cont, string descricao) {
            this.Nome = nome;
            this.Data = data;
            this.contato = cont;
            this.Descricao = descricao;
        }

        public override string retornaDados() {
            string frase = this.Data + " - " + this.Nome;
            return frase;
        }

        public override string retornaCompleto() {
            string fr = base.retornaCompleto();
            string frase = "Data: " + this.Data + "\nNome: " + fr + "\nDados: " + this.Descricao + "\nDados do Apresentador:\n" + contato.retornaCompleto();
            return frase;
        }

    }
}
