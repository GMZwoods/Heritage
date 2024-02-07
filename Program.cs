


using Heritage;

internal class program
{

    static void Main(string[] args)
    {
        //On a acces a tous ce quil y a dans la classe PERSONNE(classe Parent) voici un example 
        Etudiant e1 = new Etudiant("ABC", "EFG", "12-05-2006");
        Etudiant e2 = new Etudiant("FX", "Dubois", "17-09-1990");
        Etudiant e3 = new Etudiant("Summer ", "Shaw", "13/09/1979");
        Etudiant e4 = new Etudiant("Salma ", "Stinson", "04/09/1975");
        Etudiant e5 = new Etudiant("Deborah ", "Dickinson", "07/07/1967");
        Etudiant e6 = new Etudiant("Aysha ", "Abernathy", "04/09/1973");
        Etudiant e7 = new Etudiant("Cory ", "Chadwick", "05/04/2011");
        Etudiant e8 = new Etudiant("FX", "Dubois", "17-09-1990");

        /*
                e1.Equals(e2);
                Console.WriteLine(e1.Equals(e2));
                e1.Equals(e8);
                Console.WriteLine(e1.Equals(e8));
        */
        Console.WriteLine(e7.ToString());



    }
   

}





















