using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class CarteCredit:Paiement
    {
        public int NumeroCarte { get; set; }
        public CarteCredit(double montant, string description, int carte) : base(montant,description)
        {
            Montant= montant;  
            Description= description;
            NumeroCarte = carte;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($" Carte de credit -Montant: {Montant}, Description: {Description}, Carte:{NumeroCarte}");
        }
    }
}

