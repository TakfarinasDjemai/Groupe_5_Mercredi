using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe_5_Mercredi
{
    internal class Cours {
        public static int nb=0;
        public int NumeroCour { get; set ;} 
        public int Code { get;private set} 
        public string Titre { get; set} 

        public Cours(int numeroCour, int code, string titre) { 
       
       `    this.NumeroCour = numeroCour;
            this.Code = ++nb;
            this.Titre = titre;
        }
        
        public  string ToString(){               
           return $"Numero de Cour  :{this.NumeroCour} " + "\n" +
            $"Titre de Cour : {this.Titre} " + "\n" +
            $" Code de Cour: {this.Code}";
        }
       
        public bool Egalite(Cours c){
            return c.NumeroCour == this.NumeroCour &&
                    c.Code == this.Code &&
                    c.Titre== this.Titre;
        }
    }
}
