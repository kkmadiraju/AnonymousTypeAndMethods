//Console.WriteLine("Hello, World!");
var employee = new
{
    Id = 101,
    Name = "Kiran",
    Department = "IT"
};

Console.WriteLine(employee.Id);
Console.WriteLine(employee.Name);
Console.WriteLine(employee.Department);

//Common use with LINQ

var employees = new[]
{
    new { Id = 1, Name = "Alice", Salary = 50000 },
    new { Id = 2, Name = "Bob", Salary = 60000 }
};

var result = employees.Select(e => new
{
    e.Name,
    e.Salary
});

var family = new[] { new {Id=1, FirstName="kiran", LastName="kumar",DOB="29/23/23" },
                    new {Id=2, FirstName="Pani", LastName="kumar",DOB="29/23/23" },
                    new {Id=3, FirstName="Bobby", LastName="kumar",DOB="29/23/23"} };

var selectedmembers = family.Select(k => new { k.Id, k.DOB }).;

foreach (var member in selectedmembers)
{
    Console.WriteLine($"{member.Id} - {member.DOB}");
}