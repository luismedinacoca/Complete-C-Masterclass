namespace S05L108_DefiningAPropertySet;

class Program
{
    static void Main(string[] args)
    {
        Car audi = new Car("A3", "Audi");
        Car bmw = new Car("i7", "BMW");

        Console.WriteLine("Please enter the Brand name: ");
        audi.Brand = Console.ReadLine();
        
        Console.WriteLine($"Brand is {audi.Brand}");
    }
}