TestRecord t = new()
{
    FirstName = "Arthur",
    LastName = "Miranda"
};

//expressão 'with' com records
TestRecord t2 = t with
{
    FirstName = "Carlos"
};

System.Console.WriteLine(t2); //TestRecord { FirstName = Carlos, LastName = Miranda }

//positional records
TestRecordTwo t3 = new("Lucas", "Silva");

var (firstName, lastName) = t3;
System.Console.WriteLine(firstName); //Lucas
System.Console.WriteLine(lastName); //Silva

public record TestRecord()
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

//positional records
public record TestRecordTwo(string firstName, string lastName);