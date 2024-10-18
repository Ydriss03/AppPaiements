using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{

    public class Paiements
    {
        public string Description { get; set; }
        public int Montant { get; set; }

        public Paiements(string description, int montant)
        {
            Description = description;
            Montant = montant;
        }

       

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"motif: {Description} montant {Montant}");
        }

    }
}
