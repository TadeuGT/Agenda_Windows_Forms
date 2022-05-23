using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8TrabalhoAgenda {
    public class Contatos : IListar<Contato> {
        public List<Contato> contatos = new List<Contato>();

        public void Adicionar(Contato c1) {
            contatos.Add(c1);
        }

        public void Remover(int index) {
            contatos.RemoveAt(index);
        }

        public void LimparLista() {
            contatos.Clear();
        }

        public string Visualizar(int index) {
            return contatos.ElementAt(index).retornaCompleto();
        }

        public Contato Encontrar(int ind) {
            return contatos.ElementAt(ind);
        }

    }
}
