using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métier
{
    class CarnetBattue
    {
        private int num { get; set; }
        private DateTime date { get; set; }
        private DateTime heureDébut { get; set; }
        private DateTime heureFin { get; set; }
        private ChefBattue chef { get; set; }
        private List<Adhérent> lesAdhérents { get; set; }

    }
}
