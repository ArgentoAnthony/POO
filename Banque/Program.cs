using FilRougeBanque.Models;

Banque banque = new Banque()
{
    Name = "Les voleurs de grands chemins",
};

Personne p = new Personne();

p.Nom = "Bya";
p.Prenom = "Seb";
p.DateNaiss = new DateTime(1991, 3, 27);

Courant c = new Courant();
c.Numero = "1";
c.LigneDeCredit = 500;
c.Titulaire = p;

Personne p2 = new Personne()
{
    Nom = "Bond",
    Prenom = "James",
    DateNaiss = new DateTime(1950, 2, 23)
};

Courant c2 = new Courant()
{
    Numero = "2",
    LigneDeCredit = 10000,
    Titulaire = p2,
};

banque.Ajouter(c);
banque.Ajouter(c2);

Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");
banque["1"].Depot(1000);
Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");
banque["1"].Retrait(1250);
Console.WriteLine($"{banque["1"].Numero} : {banque["1"].Titulaire.Nom} : {banque["1"].Solde}");


Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
banque["2"].Depot(2000);
Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");
banque["2"].Retrait(1000);
Console.WriteLine($"{banque["2"].Numero} : {banque["2"].Titulaire.Nom} : {banque["2"].Solde}");

Console.WriteLine(1000 + c2);

// Solde de 1000 + 3% d'interet = 1030
c2.AppliquerInteret();

Console.WriteLine(banque.AvoirDesComptes(p2));

ICustomer customer = c2;
IBanker banker = c2;

customer.Depot(10000);
banker.AppliquerInteret();




