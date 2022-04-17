using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojetFinalAssurancelogiciel
{
    internal class Notes : Etudiant
    {
        //public int NumeroEtudiant { get; set; }
        //public int NumeroCour { get; set; }
        public double Note { get; set; }


         public Notes(int numeroEtudiant, string nom, string prenom,int numeroCour, int code, string titre, double note) :
            base(numeroEtudiant,nom,prenom,numeroCour,code,titre)
        {
            Note = note;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Cube)) return false;
            Notes other = (Notes)obj; //OPERATION DE CONVERSION
            return base.Equals(obj) &&
                Note == other.Note;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        //6- Doit-on redéfinir la méthode ToString?
        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Note : {Note}";
        }
    }
}
