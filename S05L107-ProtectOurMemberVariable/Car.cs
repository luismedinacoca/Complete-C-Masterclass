namespace S05L107_ProtectOurMemberVariable;

internal class Car
{
    // member variable
    // private hides the variable from other classes
    private string _model = "";

    /*
    prop key word
    public string Model { get; set; }
    */
    
    public string Model
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string _brand = "";

    // constructor
    public Car(string model, string brand)
    {
        _model = model;
        _brand = brand;
        Console.WriteLine($"An {_brand} of the model {_model} has been created");
    }
}