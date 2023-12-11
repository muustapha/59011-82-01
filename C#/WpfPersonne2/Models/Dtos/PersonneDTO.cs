using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDbPersonne.Models.Dtos
{
    public class PersonneDTO
    {

        public string Nom { get; set; } = null!;

        public string Prenom { get; set; } = null!;

        public int? CodePostal { get; set; }

        public string? Adresse { get; set; }

        public string? Ville { get; set; }
    }

}
