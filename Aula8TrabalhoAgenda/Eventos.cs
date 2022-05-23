using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8TrabalhoAgenda {
    public class Eventos : IListar<Evento> {
        public List<Evento> eventos = new List<Evento>();

        public void Adicionar(Evento e1) {
            eventos.Add(e1);
        }

        public void Remover(int index) {
            eventos.RemoveAt(index);
        }

        public void LimparLista() {
            eventos.Clear();
        }

        public string Visualizar(int index) {
            return eventos.ElementAt(index).retornaCompleto();
        }

    }
}
