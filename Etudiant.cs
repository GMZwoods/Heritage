using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    internal class Etudiant : Personne 
    {
        // on doit faire appel au constructeur de la classe PARENT avec base : (args requis) 
        public string NumEtudiant { get; set; }

        public Etudiant(string nom, string prenom, string ddn, string numetudiant) : base(nom, prenom, ddn)
        {
            NumEtudiant = numetudiant;

        }

        //Ajouter un second constructeur qui initialise le nom, lannée dn
        //le # etudiant 
        //est créer en cocatenant la nom, le  prenom, la date de naissance

        //public Etudiant(string nom, string prenom, string ddn) : base(nom, prenom, ddn)
        //{
        //    NumEtudiant = nom + ddn.Substring(6);

        //}
        //En haut et en bas c'est la meme chose ici
        public Etudiant(string nom, string prenom, string ddn) : this(nom, prenom, ddn, nom + ddn.Substring(6))
        {


        }
        // Redefinition de la methodes Equals() AKA POLYMORPHISME 
        /// <summary>
        /// 1. OBJ FDOIT ETRE NON NULL 2. //OBJ DOIT ETRE DE MEME TYPE QUE LA CLASSE (Cast) 3. // IMPLEMENTER LE CRITERES DEGALITE
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (!(obj is Etudiant)) { return false; }
            Etudiant e = (Etudiant)obj;

            return base.Equals(e) && this.NumEtudiant == e.NumEtudiant;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + "Numéro Étudiant : " + this.NumEtudiant + "\n";
        }
        public override string CreerLogin()
        {
            return base.CreerLogin() + NumEtudiant;
        }
    }
}
