using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula8TrabalhoAgenda {
    public abstract class Cadastro {
        protected string Nome { get; set; }

        public abstract string retornaDados();

        public virtual string retornaCompleto() {
            return Nome;
        }

    }
}
