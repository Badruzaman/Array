

using Newtonsoft.Json;

Employee employee = new Employee { Id = 1, Name = "badru" };
var result = JsonConvert.SerializeObject(employee);
Console.WriteLine("Serialization ");
Console.WriteLine(result);
var deserialize = JsonConvert.DeserializeObject<Employee>(result);
Console.WriteLine("Deserialization ");
Console.WriteLine(deserialize.Id + " " + deserialize.Name);
Console.ReadKey();

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
}


