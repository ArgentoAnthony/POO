using ReexplicationBanque.Models;

// declaration + instanciation d'un objet client de la classe Personne
Personne client = new Personne();
client.Nom = "Argento";
client.Prenom = "Anthony";
client.Datenaiss = new DateTime(1991, 11, 26);

Courant c = new Courant();
c.Numero = "123";
c.LigneDeCredit = 100;
//c.Solde = 500;
c.Titulaire = client;
// Pour manipuler le solde on doit passer par Dépot ou retrait
c.Depot(100);
Console.WriteLine(c.Solde);
c.Retrait(100);

Console.WriteLine(c.Solde);
