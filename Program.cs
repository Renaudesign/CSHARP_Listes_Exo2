using System;
using System.Collections.Generic;

namespace CSHARP_Listes_Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //créer la liste des languages
            List<string> languages = new List<string>();
            languages.Add("HTML");
            languages.Add("CSS");
            languages.Add("Javacrit");
            languages.Add("jQuery");
            languages.Add("PHP");
            languages.Add("Bootstrap");
            languages.Add("Java");

            //afficher la liste 
            Console.WriteLine("\nUtilisateur, voici une liste de languages de programmation non exhaustive :\n");
            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }

            //afficher le 4e élément de la liste
            Console.WriteLine("\nUtilisateur, le 4ème élément de la liste est: " + languages[3]);

            //afficher lle contenu de l'indice 4
            Console.WriteLine("\nUtilisateur, l'élément en indice 4 de la liste est: " + languages[4]);

            //Supprimer Bootstrap
            languages.Remove("Bootstrap");

            //Modifier Javacrit en Javascript
            int index = languages.IndexOf("Javacrit");
            languages[index]= "Javascript";

            //Ajouter C dans la liste.
            languages.Add("C");

            //afficher la liste 
            Console.WriteLine("\nUtilisateur, voici une liste de languages de programmation non exhaustive :\n");
            foreach (string language in languages)
            {
                Console.WriteLine(language);
            }
        }
    }
}
/*
 Créer une liste languages contenant les éléments suivants :

    HTML
    CSS
    Javacrit
    jQuery
    PHP
    Bootstrap
    Java 

Afficher toute la liste.
Afficher le 4ème élément de la liste.
Afficher l’élément à l’index 4 de la liste.
Supprimer Bootstrap de la liste.
Modifier Javacrit en Javascript.
Ajouter C dans la liste.
Afficher la liste
*/