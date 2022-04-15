using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe_5_Mercredi
{
    internal class Etudiant
    {
        //Chaque étudiant est identifié par: Aboubaker Mohamed Houssein
        //- Numéro d'étudiant
        public int NumeroEtudiant { get; set; }
        //- Nom
        public string Nom { get; set; }
        //-Prénom
        public string Prenom { get; set; }

        // Constructeur
        public Etudiant(int numeroEtudiant, string nom, string prenom)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.Nom = nom;
            this.Prenom = prenom;
        }

        // ToString
        public string ToString()
        {
            return $"Numero de Etudiant: {this.NumeroEtudiant} \n" +
                $"Nom de Etudiant: {this.Nom} \n" +
                $"Prenom de Etudiant: {this.Prenom}";
        }

        // Egalite
        public bool Egalite(Etudiant e)
        {
            return e.NumeroEtudiant == this.NumeroEtudiant && e.Nom == this.Nom &&
                e.Prenom == this.Prenom;
        }

    }
}
