using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe_5_Mercredi
{
    internal class Etudiant
    {
        //Chaque étudiant est identifié par:
        //- Numéro d'étudiant
        public int NumeroEtudiant { get; set; }
        //- Nom
        public string NomEtudiant { get; set; }
        //-Prénom
        public string PrenomEtudiant { get; set; }


        //Constructeur 
        public Etudiant(int NumeroEtudiant, string NomEtudiant, string PrenomEtudiant)
        {
            this.NumeroEtudiant = NumeroEtudiant;
            this.NomEtudiant = NomEtudiant;
            this.PrenomEtudiant = PrenomEtudiant;
        }
        public string ToString()
        {
            return $"Numero de Etudiant: {this.NumeroEtudiant} \n" +
                $"Nom de Etudiant: {this.NomEtudiant} \n" +
                $"Prenom de Etudiant: {this.PrenomEtudiant}";
        }

        // Egalite
        public bool Egalite(Etudiant e)
        {
            return e.NumeroEtudiant == this.NumeroEtudiant && e.NomEtudiant == this.NomEtudiant &&
                e.PrenomEtudiant == this.PrenomEtudiant;
        }
    }
}
