using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetFinalAssurancelogiciel
{
    internal class Cours : Etudiant
    {
        public int NumeroCour { get; private set ;} 
        public int Code { get; set} 
        public string Titre { get; set} 

        public Cours(int numeroEtudiant, string nom, string prenom,int numeroCour, int code, string titre) :
            base(numeroEtudiant,nom,prenom)

        {
            NumeroCour = numeroCour;
            Code = code;
            Titre = titre;

        }
       

        //Redéfinir la méthode Equals.
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Cours)) return false;
            Cours other = (Cours)obj; //OPERATION DE CONVERSION
            return base.Equals(obj) &&
                NumeroCour == other.NumeroCour &&
                Code == other.Code &&
                Titre == other.Titre;


        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //redifinir la methode TosTRING
        public override string ToString()
        {
            return base.ToString() + "\n" +                
            $"Cour titre : {Titre} " + "\n" +
                   $" Cour code: {Code}";
        }
    }
}
