using CsvHelper;
using System.Globalization;

namespace BlogExample.CsvExample;

internal class CsvReadExample
{
    // Replace with the directory path where the csv is saved
    private const string Path = @"";

    public void ReadCsv()
    {
        using var reader = new StreamReader($@"{Path}\user.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        
        while(csv.Read())
        {
            var user = csv.GetRecord<UserRecord>();
            Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}");
        }
        
    }
}