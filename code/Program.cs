using System;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection;
class Program
{
    static void Main()
    {
        //variable 
        Distributeur[] monDistri;
        monDistri= new Distributeur [10];//je déclare mon tableau de Distributeur 
        
        Produit[] mesProduits; // je déclare mon tableau de produit 
        mesProduits= new Produit[10];

        Emplacement[] mesEmplacements; // déclare tab Emplacement
        mesEmplacements = new Emplacement[10];

        mesEmplacement[0].referenceprod= "P6001";
        mesEmplacements[0].code="A1";
        mesEmplacements[0].stock=15;

        mesProduits[0].nom= "sandwich";
        mesProduits[0].prix= 4.20f; //prix en euros 
        mesProduits[0].reference= "P6001"; 

        string code=mesEmplacements[0].code;   
        int modePaiment; 
        int cb; 
        int liquide;    

        //---------
        //| Début |
        // --------

        // --------------------
        // | Choix du Produit |
        // --------------------

        ChoixProduit();// affiche messaeg 
        code=Console.ReadLine();// lit la saisi 
        
        for(int i=0; i<mesEmplacements.Length-1;i++) //parcour l'emplacements et choisis le produit selon le code 
        {
            if(mesEmplacements[i].code == code)
            {
                Console.Write("Vous avez pris " + mesProduits[i].nom); //affiche le choix 
                break;
            }
            for(int j = 0) // faire boucle pour parcourire le tab Produits qui est dans Emplacement 
        }


       // ----------------
       // | Mode paiment |
       // ----------------

       ModePaiment(); // affiche message 
       modePaiment=Console.ReadLine();
       if(modePaiment == cb )
        {
            Console.Write("Carte bancaire." );
        }
        else if(modePaiment == liquide)
        {
            Console.Write("En liquide." );
        }
        

        
    }

    
}