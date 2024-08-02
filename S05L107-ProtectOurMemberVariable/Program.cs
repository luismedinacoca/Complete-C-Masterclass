namespace S05L107_ProtectOurMemberVariable;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("A3", "Audi");
        Car bmw = new Car("i7", "BMW");

        /*
        audi._model = "";
        audi._brand = "";
        
        bmw._model = "";
        bmw._brand = "";
        */

        audi.Model = "new Model";
        bmw.Model = "jk23";
        
        Console.WriteLine($"Audi model is {audi.Model}");
        Console.WriteLine($"bmw model is {bmw.Model}");
    }
}