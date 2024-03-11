
using ChallengeApp;

var employee=new Employee ("Anna", "Kowalska");
employee.Addgrade(2);
employee.Addgrade(3);
employee.Addgrade(4);
var statistics= employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");


