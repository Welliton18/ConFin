using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Modelo {
    public class Cidade {

        public int cid_codigo { get; set; }

        public string nome { get; set; }

        public Estado Estado { get; set; }

        public Cidade() { }

        public Cidade(int codigo, string nome, string siglaEstado) {
            this.cid_codigo = codigo;
            this.nome = nome;
            this.Estado = new Estado(siglaEstado);
        }

    }
}
