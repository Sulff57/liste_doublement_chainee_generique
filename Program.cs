using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeChainee
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Chaine<int> chaine = new Chaine<int>();
            chaine.Ajouter(5);
            chaine.Ajouter(10);
            chaine.Ajouter(15);
            Console.WriteLine(chaine.Obtenir(0).Valeur);
            Console.WriteLine(chaine.Obtenir(1).Valeur);
            Console.WriteLine(chaine.Obtenir(2).Valeur);
        }

    }


    
}
