using System;
using System.Collections.Generic;
using System.Text;

namespace ITXamarin.Models
{
        public class Clientes
        {
            public Cliente[] cliente { get; set; }
        }

        public class Cliente
        {
            public string codigo { get; set; }
            public string name { get; set; }
            public string ruc { get; set; }
        }
}
