using Demo;
using Demo.Models;
using Demo.Models.Vehicules;
using Demo.Services;
using Demo.Utilis;
using System.Threading.Channels;
using static Demo.Utilis.Dice;

#region lambda / delegate

DemoDelegate demo = new DemoDelegate();
//demo.del += Addition;

////demo.del += delegate (int a, int b)
////{
////    Console.WriteLine(a + b);
////};

//demo.del += (int a, int b) =>
//{
//    Console.WriteLine(a - b);
//};

//demo.del += (int a, int b) => Console.WriteLine(a * b);

//demo.del(5, 3);

//static void Addition(int a, int b)
//{
//    Console.WriteLine(a + b);
//}

demo.del += (int a, int b) =>
{
    Console.WriteLine(a - b);
};

myDel lambda = (int a, int b) => Console.WriteLine(a * b);

demo.del += lambda;
demo.del -= lambda;

//demo.del(5.3);

Action<string, int> a = delegate (string name, int age) { Console.WriteLine("coucou " + name+ " tu as " + age+" ans"); };
a("Antho", 32);

List<string> list = new List<string>
{
    "Pierre",
    "Paul",
    "Jacques",
    "Bernadette"
};

list.ForEach(s => Console.WriteLine(s));




#endregion

#region Exception

//Vehicule v = new Voiture("Dodge", 10000,"Rouge");


//try
//{
//    v.Prix = -100;
//    Console.WriteLine("Success");
//}catch(NotFiveException e)
//{
//    Console.WriteLine(e.Message);
//}catch(ArgumentOutOfRangeException e)
//{
//    v.Prix = 0;
//    Console.WriteLine(e.Message);
//}catch( Exception e)
//{
//    Console.WriteLine(e.Message);  
//}

//Console.WriteLine(v);

#endregion

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

#region heritage
//Employee noreen = new Employee();

//List<Vehicule> catalog = new List<Vehicule>()
//{
//    new Voiture()
//    {
//        Marque = "Dodge",
//    Prix = 10000,
//    Couleur = "Noir"
//    },
//    new Avion()
//    {
//            Marque = "Diamond",
//    Prix = 200000,
//    Speed = 300
//    }

//};

//foreach (Vehicule v in catalog)
//{
//    Console.WriteLine(v);
//    v.Deplacer();

//}

//Console.WriteLine(/*Dice.*/Throw(5,3)); // Plus besoin de spécifier Dice. car on a fait un usine static de Dice

////Extention.SuperCamelCase("coucou");

//string s = "        cou cou";

//Console.WriteLine(s.SuperCamelCase());
//Console.WriteLine(s.Trim(true));

#endregion

//IBookService bookService = new BookService();

//bookService.Add(new Book());

//IBateau a = new Amphibie();

//a.Tourne();

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

