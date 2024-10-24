using AppPaiements;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppPaiements
{
    public class Paypal:Paiement
    {
        public string Courriel { get; set; }
        public Paypal(double montant, string description, string email) : base(montant, description)
        {
             Montant = montant;
            Description = description;
            Courriel = email;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($" Paypal- Montant: {Montant}, Description: {Description}, Courriel:{Courriel}");
        }

    }
}