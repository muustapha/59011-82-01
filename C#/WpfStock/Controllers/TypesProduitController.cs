using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStock.Controllers
{
    class TypesProduitController
    {
        private GestionstocksContext context;

        public TypesProduitController(GestionstocksContext context)
        {
            this.context = context;
        }
    }
}
