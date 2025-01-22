
class Item
{
    // variables
    public string _name = "";
    public double _amount = 0.00;
    public bool _checked = false;

    // methods (functions)
    public void Display()
    {
        Console.WriteLine($"{_name}, {_amount}, {_checked}");
    }

    public void SetChecked(bool value)
    {
        _checked = value;
    }

    public void CheckedTrue()
    {
        _checked = true;
    }

    public void CheckedFalse()
    {
        _checked = false;
    }

}
