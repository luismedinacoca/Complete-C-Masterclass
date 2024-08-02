namespace S05L106_CustomConstructor;

internal class Car
{
    // member variable
    // private hides the variable from other classes
    private string _model = "";
    private string _brand = "";
    
    // constructor
    public Car(string model, string brand)
    {
        _model = model;
        _brand =  brand;
        Console.WriteLine($"An {_brand} of the model {_model} has been created");
    }
}