System.Console.WriteLine("Hello World!");

Person p = new()
{
    Cpf = "06666600660",
    Name = "João"
};

p.Cpf = "não pode fazer isso";

System.Console.WriteLine(p.Cpf, p.Name); //error CS8852: Init-only property or indexer 'Person.Cpf' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.

public class Person
{
    public string Cpf { get; init; }
    public string Name { get; set; }
}