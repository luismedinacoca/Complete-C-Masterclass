namespace S05L109_ModifyingGetPropertyPart01;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("A3", "Audi", false);
        Car bmw = new Car("i7", "BMW", true);
        Console.WriteLine("");
        
        Console.WriteLine($"Brand is {audi.Brand}");
        Console.WriteLine($"Brand is {bmw.Brand}");
    }

}