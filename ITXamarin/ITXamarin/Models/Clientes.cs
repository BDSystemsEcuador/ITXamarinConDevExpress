using System;
using System.Collections.Generic;
using System.Text;

namespace ITXamarin.Models
{
    public class WCFClientes
    {
        public WCFCliente[] Clientes { get; set; }
    }
    public class WCFCliente
    {
        public int codigo { get; set; }
        public string name { get; set; }
        public string ruc { get; set; }
    }
}
