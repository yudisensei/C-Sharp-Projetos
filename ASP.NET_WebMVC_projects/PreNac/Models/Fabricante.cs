using System.Collections.Generic;

namespace PreNac.Models
{
    public class Fabricante
    {
        public int FabricanteId { get; set; }
        public string Nome { get; set; }
        
        //Relacionamento um-para-muitos
        public IList<Carro> carros { get; set; }
    }
}