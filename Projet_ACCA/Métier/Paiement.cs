using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    class Paiement
    {
        private DateTime datePaiement { get; set; }
        private String moyenDePaiment { get; set; }
        private Adhérent payeur { get; set; }
        private double tarif { get; set; }
    }
}
