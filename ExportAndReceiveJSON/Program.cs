using System.Text.Json;
using System.Text.Json.Serialization;

List<data> _data = new List<data>();
_data.Add(new data()
{
    Id = 1,
    SSN = 2,
    Message = "A Message"
});

string json = JsonSerializer.Serialize(_data);
File.WriteAllText(@"C:\Users\user\Downloads\JSONFile.json", json);

List<data> _data1 = new List<data>();
string s= File.ReadAllText(@"C:\Users\user\Downloads\JSONFile.json");
Console.WriteLine($"s= {s}");
class data
{
    public int Id { get; set; }
    public int SSN { get; set; }
    public string Message { get; set; }
}