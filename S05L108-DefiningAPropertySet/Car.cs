namespace S05L108_DefiningAPropertySet;

internal class Car
{
    //Member variable:
    private string _model = "";
    private string _brand = "";

    public string Model
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public string Brand
    {
        get => _brand;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You entered NOTHING!");
                _brand = "DEFAULT VALUE";
            }
            else
            {
                _brand = value;    
            }
        }
    }

    // constructor
    public Car(string model, string brand)
    {
        _model = model;
        _brand = brand;
        Console.WriteLine($"An {_brand} of the model {_model} has been created");
    }
}