using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Modelo {
    public class Conta {

        public Pessoa Pessoa { get; set; }

        public int cnt_numero { get; set; }

        public string descricao { get; set; }

        public string data { get; set; }

        public float valor { get; set; }

        public char tipo { get; set; }

        public char situacao { get; set; }

        public Conta() { }

    }
}
