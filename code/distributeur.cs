using System;
class test
{
  static void Main()
  {
    Distributeur[] monDistri = new Distributeur[10];// on crée un tableau de distributeurs de taille 10 pour stocker les distributeurs créés par l'utilisateur

    Console.WriteLine("Bienvenue dans le programme de gestion des distributeurs!");
    Console.WriteLine("Veuillez saisir votre nom d'utilisateur:");
    string user = Console.ReadLine();

   gestion_Distributeur(monDistri, user);

    Console.WriteLine("Merci d'avoir utilisé le programme de gestion des distributeurs. Au revoir!");
    
   
  }

  struct Distributeur // on définit une structure Distributeur qui contient les informations d'un distributeur
  {
    public string id;
    public string nomOrganisation;
    public string loc;



  }








  static Distributeur creer_Distributeur()
  {
    Distributeur distributeur ;
    while(distributeur.id == null || distributeur.id.Length != 5) // tant que l'ID est null ou que sa longueur n'est pas égale à 5, on continue à demander à l'utilisateur de saisir un ID valide
    {
      Console.Write("Veuillez créer un nouveau distributeur.Commencer par remplir son ID:"); 
          distributeur.id = Console.ReadLine();
          if (distributeur.id !=null && distributeur.id.Length == 5) // si l'ID est valide, on demande à l'utilisateur de saisir la localisation et le nom de l'organisation
      {
        Console.Write("veuillez saisir sa localisation: ");
          distributeur.loc = Console.ReadLine();
          Console.Write("veuillez saisir le nom de l'organisation: ");
         distributeur.nomOrganisation = Console.ReadLine();
      }
        else if(distributeur.id == null || distributeur.id. Length !=5)
      {
        Console.Write("Erreur! L'ID doit contenir 5 caractères. Veuillez réessayer."); // si l'ID n'est pas valide, on affiche un message d'erreur et on continue à demander à l'utilisateur de saisir un ID valide
      }
    } 
    return distributeur;
  }


  static void gestion_Distributeur(Distributeur[] monDistri, string user)
  {
   Distributeur nvDistri=creer_Distributeur();// on appelle la fonction creer_Distributeur() pour créer un nouveau distributeur
 
    
    for( int j =0; j<monDistri.Length; j++)// on parcourt le tableau de distributeurs pour ajouter le nouveau distributeur
    {
      monDistri[j]=nvDistri;// on ajoute le nouveau distributeur à la première case vide du tableau

        Console.WriteLine("Le distributeur a été créé avec succès :)!");
        Console.WriteLine("Voulez-vous créer un autre distributeur? (tapez 'continuer' pour en créer un autre ou 'fin' pour arrêter)");
        user = Console.ReadLine();

     if(user == "continuer")// si l'utilisateur veut créer un autre distributeur, on appelle la fonction creer_Distributeur() pour créer un nouveau distributeur
      {
        nvDistri=creer_Distributeur();
      }
      else if(user == "fin")// si l'utilisateur veut arrêter, on sort de la boucle
      {
        break;
      }
      
    }
  
  }

}











