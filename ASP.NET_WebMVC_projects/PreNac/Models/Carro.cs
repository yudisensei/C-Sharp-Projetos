using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreNac.Models
{
    public class Carro
    {
        public int CarroId { get; set; }
        public string modelo { get; set; }
        public int ano { get; set; }

        public Combustivel combustivel { get; set; }

        //Relacionamento muitos-para-um
        public Fabricante Fabricante { get; set; }

        public int FabricanteId { get; set; }    
    }

}