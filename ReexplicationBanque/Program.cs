using ReexplicationBanque.Models;

// declaration + instanciation d'un objet client de la classe Personne
Personne client = new Personne();
client.Nom = "Argento";
client.Prenom = "Anthony";
client.DateNaiss = new DateTime(1991, 11, 26);

Personne client2 = new Personne()
{
    Nom = "Bond",
    Prenom = "James",
    DateNaiss = new DateTime(1950, 2, 23)
};

Courant c = new Courant();
c.Numero = "123";
c.LigneDeCredit = 100;
//c.Solde = 500;
c.Titulaire = client;

Courant c2 = new Courant()
{
    Numero = "2",
    LigneDeCredit = 10000,
    Titulaire = client2,
};
// Pour manipuler le solde on doit passer par Dépot ou retrait
c.Depot(100);
c.Retrait(100);

Courant c3 = new Courant()
{
    Numero = "456",
    LigneDeCredit = 500,
    Titulaire = client,
};

c3.Depot(1000);


Banque belfius = new Banque();
belfius.Name = "Belfius";

belfius.Ajouter(c);
belfius.Ajouter(c3);

Epargne e = new Epargne();


//Console.WriteLine(belfius["123"].Titulaire.DateNaiss.Day);

//Courant nouveauCompte = creerCompte();

//belfius.Ajouter(nouveauCompte);

foreach (Courant compte in belfius.Comptes.Values)
{
    Console.WriteLine(compte);
}

//Console.WriteLine("Quel compte voulez vous regarder?");
//string num = Console.ReadLine();
//Console.WriteLine(belfius[num]);

c2.Depot(1000);
Console.WriteLine(1000M + c2);

Console.WriteLine(belfius.AvoirDesComptes(client2));

Courant creerCompte()
{
    Console.WriteLine("Titulaire du compte : ");
    Console.Write("Nom : ");
    string nom = Console.ReadLine();
    Console.Write("Prenom : ");
    string prenom = Console.ReadLine();
    Console.WriteLine("Date de naissance : ");
    Console.Write("Jour : ");
    int jour = int.Parse(Console.ReadLine());
    Console.Write("Mois : ");
    int mois = int.Parse(Console.ReadLine());
    Console.Write("Annee : ");
    int annee = int.Parse(Console.ReadLine());
    Console.WriteLine("Compte :");
    Console.Write("Numero : ");
    string numero = Console.ReadLine();
    Console.Write("Ligne de credit : ");
    int ligneDeCredit = int.Parse(Console.ReadLine());

    Courant nouveauCompte = new Courant()
    {
        Numero = numero,
        LigneDeCredit = ligneDeCredit,
        Titulaire = new Personne()
        {
            Nom = nom,
            Prenom = prenom,
            DateNaiss = new DateTime(annee, mois, jour)
        }
    };
    return nouveauCompte;
}

