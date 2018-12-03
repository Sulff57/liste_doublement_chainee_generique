using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeChainee
{
    public class Chainon<T>
    {
        public Chainon<T> Precedent;
        public Chainon<T> Suivant;
        public T Valeur;

        public Chainon(T valeur)
        {
            Valeur = valeur;
        }
    }

    
    public class Chaine<T>
    {

        Chainon<T> Premier;


        public Chainon<T> Dernier() 
        {
            Chainon<T> dernier = Premier;
            while (dernier.Suivant != null)
            {
                dernier = dernier.Suivant;
            }
            return dernier;
        }

        public void Ajouter(T element)
        {
            Chainon<T> chainon = new Chainon<T>(element);
            if (Premier == null)
            {
                Premier = chainon;
            }
            else
            {
                Chainon<T> dernier = this.Dernier();
                dernier.Suivant = chainon;
                chainon.Precedent = dernier;
            }
        }

        public Chainon<T> Obtenir(int indice)
        {
            int i = 0;
            Chainon<T> resultat = Premier;
            while (i < indice)
            {
                i += 1;
                resultat = resultat.Suivant;
            }
            return resultat;
        }

        public void Inserer(T element, int indice)
        {
            Chainon<T> chainon = new Chainon<T>(element);
            int i = 0;
            Chainon<T> chainonPrecedent = this.Premier;
            while (i < indice)
            {
                i++;
                chainonPrecedent = chainonPrecedent.Suivant;
            }
            Chainon<T> temp = chainonPrecedent.Suivant;
            chainonPrecedent.Suivant = chainon;
            chainon.Precedent = chainonPrecedent;
            temp.Precedent = chainon;
            chainon.Suivant = temp;


        }


    }

    




}
