namespace S05L106_CustomConstructor;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("A3", "Audi");
        Car bmw = new Car("i7", "BMW");

        /*
        audi._model = "";
        audi._band = "";
        
        bmw._model = "";
        bmw._brand = "";
        */
        Console.ReadKey();
    }
}