using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Groupe
    {
        public List<Personne> Personnes { get; set; } = new List<Personne>();



        /// <summary>
        /// Ajouter n'accepte pas les doublons 
        /// </summary>
        /// <returns></returns>
        public bool AjouterPersonne(Personne p)
        {
            if (!Personnes.Contains(p))
            {
                Personnes.Add(p);
                return true;
            }
            else { return false; }

        }
        public bool SupprimerPersonne(Personne p)
        {
            if (Personnes.Contains(p))
            {
                Personnes.Remove(p);  
                return true;
            }
            return false;
        }
        public List<Personne> ChercherPersonnes(string nom)
        {
            List<Personne> Result = new List<Personne>();   
            foreach (Personne p in Personnes) 
            {
                if(p.Nom == nom) 
                {
                    
                }
            }

        }
    }
}
