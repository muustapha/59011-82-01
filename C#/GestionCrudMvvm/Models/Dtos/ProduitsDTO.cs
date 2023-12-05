using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCrudMvvm.Models.Dtos
{
    public class ProduitsDTO
    {
        public string Nom { get; set; }
        public double Prix { get; set; }
        public double CoutProduction { get; set; }
        public int Quantite { get; set; }
        public string LieuxProduction { get; set; }
    }
}
