using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    public class Adhérent
    {
        private String matricule { get; set; }
        private String nom { get; set; }
        private String prenom { get; set; }
        private DateTime dateAdhésion { get; set; }
        private DateTime dateDépart { get; set; }
        private String motif { get; set; }
        private int numTel { get; set; }
        private String ville { get; set; }
        private int codePostal { get; set; }
        private String adresse { get; set; }
        private String lieuDit { get; set; }

    }
}
