using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe_5_Mercredi
{
    internal class Notes
    {
        //Chaque étudiant est identifié par:
        //-Numéro d'étudiant
        public List<Etudiant> Etudiants { get; set; } = new List<Etudiant>();
        public int NumeroEtudiant { get; set; }
        //-Numéro du cours
        public List<Cours> Cour { get; set; } = new List<Cours>();
        public int NumeroCour { get; set; }
        //-Note
        public int Note { get; set; }



        //-Constructeur
        public Notes(int NumeroEtudiant, int NumeroCour, int Note)
        {
            this.NumeroEtudiant = NumeroEtudiant;
            this.NumeroCour = NumeroCour;
            this.Note = Note;
        }



        public void AjouterEtudiant(Etudiant e)
        {
            Etudiants.Add(e);
        }



        public void AjouterCours(Cours c)
        {
            Cour.Add(c);
        }



        public string ToString()
        {
            int x = this.NumeroEtudiant;
            int y = this.NumeroCour;
            foreach (Cours c in Cour)
            {   foreach (Etudiant e in Etudiants)
                    { if (c.NumeroCour == y && e.NumeroEtudiant == x)
                        {   return $"Note: {this.Note} \n" +
                                        e.ToString() + "\n" +
                                        c.ToString();
                        }        
                       else if (e.NumeroEtudiant == x)
                       {
                          return $"Note: {this.Note} \n" +
                                        e.ToString();
                       }
                      else if(c.NumeroCour == y)
                      {
                          return $"Note: {this.Note} \n" +
                                        c.ToString();
                      }
                    }
            }
            return null;
        }

        public bool Egalite(Notes n)
        {
            return n.NumeroEtudiant == this.NumeroEtudiant && n.NumeroCour == this.NumeroCour &&
                n.Note == this.Note;
        }
    }
}
