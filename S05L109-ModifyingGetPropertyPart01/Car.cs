namespace S05L109_ModifyingGetPropertyPart01;

internal class Car
{
    //Member variable:
    private string _model = "";
    private string _brand = "";
    private bool _isLuxury;

    // constructor
    public Car(string model, string brand, bool isLuxury)
    {
        _model = model;
        _brand = brand;
        Console.WriteLine($"An {_brand} of the model {_model} has been created");
        _isLuxury = isLuxury;
    }
    
    // Property:
    public string Model
    {
        get => _model;
        set => _model = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public bool IsLuxury
    {
        get => _isLuxury;
        set => _isLuxury = value;
    }
    public string Brand
    {
        get {
            if (_isLuxury) {
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
}
