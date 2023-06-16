using Demo.Models;
using Demo.Models.Vehicules;

#region surcharge

//Casting c = new Casting()
//{
//    Name = "Casting DMC",
//    Entities = new List<Entity>()
//    {
//        new Entity("Dante"),
//        new Entity("Vergil"),
//        new Entity("Nero")
//    },
//};

//c["Dante"].Stats[StatType.Hp] = 800000000;


//Console.WriteLine(c["Vergil"]);
//Entity fusion = c.Entities[0] + c.Entities[1];
//c.Entities.Add(fusion);

//Entity dante = new Entity("Dante");


//foreach (Entity entity in c.Entities)
//{
//    Console.WriteLine(entity);
//}

//Console.WriteLine(c["Dante"]);
//Console.WriteLine(dante == c.Entities[0]);

#endregion

//Employee noreen = new Employee();

List<Vehicule> catalog = new List<Vehicule>()
{
    new Vehicule()
    {
        Marque = "Hyundai",
        Prix = 9999
    },
    new Voiture()
    {
        Marque = "Dodge",
    Prix = 10000,
    Couleur = "Noir"
    },
    new Avion()
    {
            Marque = "Diamond",
    Prix = 200000,
    Speed = 300
    }

};

foreach (Vehicule v in catalog)
{
    Console.WriteLine(v);
    //v.Deplacer();
    switch (v)
    {
        case Voiture vo:
            vo.Deplacer();
            break;
        case Avion a:
            a.Deplacer(); 
            break;
        case Vehicule ve:
            ve.Deplacer(); 
            break;
    }
}





#region demo 2 indexeur

//Catalog catalog1 = new Catalog();

//catalog1.Name = "Pas mal!";

//Person person1 = new Person()
//{
//    Id = 1,
//    Name = "Georges",
//    PhoneNumber = "01234",
//    Address = "Rue cerisier numero 18"
//};

//catalog1.AddPerson(person1);

//Console.WriteLine(catalog1["01234"]);

//catalog1["123"] = new Person()
//{
//    Id = 2,
//    Name = "Seb",
//    PhoneNumber = "123",
//    Address = "test"
//};

//Console.WriteLine(catalog1["123"]);
////Dictionary<int,string> communes = new Dictionary<int,string>();

////communes.Add(4347, "Fexhe le Haut Clocher");

////Console.WriteLine(communes[4347]);
////Console.WriteLine(communes.ContainsKey(4347));

#endregion

