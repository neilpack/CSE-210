// Week 5 Encapsulation Notes
// Encapsulation is making data private but the methods or classes public.
// I want to protect my data, essentially I am protecting it from other classes
// Or I am protecting it from myself, keeping it from crashing
class Person {
    public int _age;
    public string _name;
    public Person() { //Default Constructor
        _age = 0;
        _name = "unknown";
    }
    public Person(int age, string name) {
        _age = age;
        _name = name;
    }
Person Fred = new Person(10, "Fred")
// The above is a method or function to create something quicker
}

class Person1 {
    // attributes
    private int _age;
    private int _weight;

    // methods

    // Constructors
    public Person() 
    {
        _age = -1;
        _weight = -1;
    }
    public Person(int age)
    {
        _age = age;
        _weight = -1;
    }
    public Person(int weight)
    {
        _age = age;
        _weight = weight;
    }
    // get/set
    public void SetAge(int age)
    {
        if (age < 0 [] age > 120)
        {
            throw new ArguementException("Age must be between 0 and 120")
        }
        _age = age;
    }
    public void Display()
    {
        Console.WriteLine($"Age = {_age}")
    }
}