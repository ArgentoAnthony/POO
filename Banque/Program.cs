using FilRougeBanque;
using FilRougeBanque.Models;
using System.ComponentModel.DataAnnotations.Schema;

Banque banque = new Banque()
{
    Name = "Les voleurs de grands chemins",
};

Personne p = new Personne("Bya", "Seb", new DateTime(1991, 3, 27));
//{
//    Nom = "Bya",
//    Prenom = "Seb",
//    DateNaiss = new DateTime(1991, 3, 27)
//};



Courant c = new Courant("1",p,500);
//c.Numero = "1";
//c.LigneDeCredit = 500;
//c.Titulaire = p;

Personne p2 = new Personne("Bond", "James", new DateTime(1950, 2, 23));
//{
//    Nom = "Bond",
//    Prenom = "James",
//    DateNaiss = new DateTime(1950, 2, 23)
//};

Courant c2 = new Courant("2",p2,10000);
{
    //Numero = "2",
    //LigneDeCredit = 10000,
    //Titulaire = p2,
};

banque.Ajouter(c);
banque.Ajouter(c2);

//Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");
//banque["1"].Depot(1000);
//Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");
//banque["1"].Retrait(1250);
//Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");


//Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
//banque["2"].Depot(2000);
//Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
//banque["2"].Retrait(1000);
//Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");

//Console.WriteLine(1000 + c2);

// Solde de 1000 + 3% d'interet = 1030
c2.AppliquerInteret();

Console.WriteLine(banque.AvoirDesComptes(p2));

ICustomer customer = c2;
IBanker banker = c2;

customer.Depot(10000);
banker.AppliquerInteret();


try
{
    c2.Depot(100);
    c2.Retrait(99999999);
    Compte C3 = new Courant("3", new Personne("Jin-Woo","Sung", new DateTime(1991,11,26)),-500);
    Console.WriteLine("Success");
}
catch (SoldeInsuffisantException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



