﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confin.Modelo {
    public class Pessoa {

        public Cidade Cidade { get; set; }

        public int pes_codigo { get; set; } 

        public string nome { get; set; } 

        public int idade { get; set; }

        public string email { get; set; } 

        public Pessoa() { }
    }
}
