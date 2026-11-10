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
        
        mesProduits[0].nom= "sandwich";
        mesProduits[0].prix= 4.20f; //prix en euros 
        mesProduits[0].reference= "P6001"; 
        



    }
    
}