using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetFinalAssurancelogiciel
{
    internal abstract class Etudiant 
    {
        
        public int NumeroEtudiant { get; private set ;} 
        public string Nom { get; set ;} 
        public string Prenom { get; set ;} 

        public Etudiant(int numeroEtudiant, string nom, string prenom) :
         
        {
            NumeroCour = numeroEtudiant;
            Nom = nom;
            Prenom = prenom;
        }
         //Redéfinir la méthode Equals.
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(Etudiant)) return false;
            Etudiant other = (Etudiant)obj; //operationn de Conversion / Cast (as)
            return base.Equals(obj) &&
                 Nom == other.Nom &&
                Prenom == other.Prenom;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        //6- Redéfinir la méthode ToString.
        public override string ToString()
        {
            
               return $"Student's nom : {Nom}" + "\n"+
                $"Student's Prenom : {Prenom}" + "\n" ;
        }


     

        
        
    }
}
