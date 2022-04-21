using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groupe_5_Mercredi
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant(2699880, "Aboubaker", "Mohamed");
            Etudiant e2 = new Etudiant(2832043, "Abdoul", "Karim");

            Console.WriteLine(e1.ToString());
            Console.WriteLine("******************************");
            Console.WriteLine(e2.ToString());
            Console.WriteLine("******************************");
            Console.WriteLine(e2 == e1);
            Console.WriteLine("******************************");

            Cours c1 = new Cours(20304, "Math");
            Cours c2 = new Cours(32942, "English");

            Console.WriteLine(c1.ToString());
            Console.WriteLine("******************************");
            Console.WriteLine(c2.ToString());
            Console.WriteLine("******************************");
            Console.WriteLine(c2 == c1);
            Console.WriteLine("******************************");


            Notes n1 = new Notes(2699880, 20304, 32);
            Notes n2 = new Notes(2832043, 32942, 24);

            n1.AjouterCours(c1);
            n1.AjouterEtudiant(e1);
            n2.AjouterCours(c2);
            n2.AjouterEtudiant(e2);

            Console.WriteLine(n1.ToString());
            Console.WriteLine("******************************");
            Console.WriteLine(n2.ToString());
            Console.WriteLine("******************************");
            Console.WriteLine(n2 == n1);
    
        }
    }
}
