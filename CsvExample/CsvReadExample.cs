using CsvHelper;
using System.Globalization;

namespace BlogExample.CsvExample;

internal class CsvReadExample: CsvExample
{
    public void ReadCsv()
    {
        using var reader = new StreamReader($@"{DirectoryPath}\user.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        
        while(csv.Read())
        {
            var user = csv.GetRecord<UserRecord>();
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
    }

    public void ReadMultiRecords()
    {
        using var reader = new StreamReader($@"{DirectoryPath}\user.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        //var users = csv.GetRecords<UserRecord>().ToList();
        var users = csv.GetRecords<UserRecord>();

        foreach(var user in users)
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}");
    }
}