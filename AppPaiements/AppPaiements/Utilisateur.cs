using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    public class Utilisateur
    {
        public string Nom { get; set; }
        public List<string> Paiements { get; set; }
        public Utilisateur(string nom, List<string> paiments)
        {
            Nom = nom;
            Paiements = Paiements ?? new List<string>();
        }

        public virtual void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine("Paiements :");
            foreach (var paiement in Paiements)
            {
                Console.WriteLine($" * {paiement}");
            }
        }

        public virtual void AjouterPaiement(string paiement)
        {
            if (!string.IsNullOrEmpty(paiement))
            {
                Paiements.Add(paiement);
                Console.WriteLine($"Montant du paiement : {paiement} ajouté.");
            }
            else
            {
                Console.WriteLine("Le montant du paiement ne peut pas être vide.");
            }
        }
    }
}
