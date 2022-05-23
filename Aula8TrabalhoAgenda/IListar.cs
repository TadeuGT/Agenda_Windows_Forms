using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8TrabalhoAgenda {
    interface IListar<T> {

        void Adicionar(T c);

        void Remover(int index);

        void LimparLista();

        string Visualizar(int index);

    }
}
