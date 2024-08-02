namespace S05L110_ModifyingGetPropertyPart02;

internal class Car
{
    //Member variable - backing field of the brand property only
    /*
    private string _model = "";
    private bool _isLuxury;
    */
    private string _brand = "";

    // constructor
    public Car(string model, string brand, bool isLuxury)
    {
        Model = model;
        _brand = brand;
        Console.WriteLine($"An {_brand} of the model {Model} has been created");
        IsLuxury = isLuxury;
    }
    
    // Properties:
    /*
    public string Model
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }*/
    public string Model { get; set; }
    
    public string Brand
    {
        get {
            if (IsLuxury) {
                return _brand + " - Luxury Edition";
            }
            else {
                return _brand;
            }
        }
        
        set {
            if (string.IsNullOrEmpty(value)) {
                Console.WriteLine("You entered NOTHING!");
                _brand = "DEFAULT VALUE";
            }
            else {
                _brand = value;    
            }
        }
    }
    
    /*
    public bool IsLuxury
    {
        get => _isLuxury;
        set => _isLuxury = value;
    }
    */

    public bool IsLuxury { get; set; }
}