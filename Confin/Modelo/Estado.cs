using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Modelo {
    public class Estado {

        public string est_sigla { get; set; }
        public string nome { get; set; }

        public Estado() {}

        public Estado(string siglaEstado) {
            this.est_sigla = siglaEstado;
        }

        public Estado(string est_sigla, string nome) {
            this.est_sigla = est_sigla;
            this.nome      = nome;
        }

    }
}
