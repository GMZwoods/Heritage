using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Personne 
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Ddn { get; set; }

        // ajouter un constructeur à la classe personne 
        public Personne(string nom, string prenom, string ddn)
        {
            Nom = nom;
            Prenom = prenom;
            Ddn = ddn;
        }

        // Redefinition de la methodes Equals() AKA POLYMORPHISME 
        /// <summary>
        /// // OBJ FDOIT ETRE NON NULL ,  //OBJ DOIT ETRE DE MEME TYPE QUE LA CLASSE ,  // IMPLEMENTER LE CRITERES DEGALITE
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {


            if (obj == null) return false;


            if (!(obj is Personne)) { return false; }

            Personne p = (Personne)obj;
            return p.Nom == this.Nom && p.Prenom == this.Prenom && this.Ddn == p.Ddn;
        }

        public override string ToString()
        {
            return "Nom :" + this.Nom + "\n" + "Prenom :" + this.Prenom + "\n" + "Ddn :" + this.Ddn;
        }

        //definition de la methiode Creerlogin --Virtual classe parent --

        public virtual string CreerLogin()
        {
            return Nom.Substring(0, 2) + Prenom.Substring(0, 2);


        }


    }

}
