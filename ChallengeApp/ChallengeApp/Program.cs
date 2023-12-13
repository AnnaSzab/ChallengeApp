using ChallengeApp;

var employee1 = new Employee ("Anna", "Kowalska", 33);
var employee2 = new Employee ("Basia","Polak",22);
var employee3 = new Employee ("Pawel","Diabel",45);

employee1.Addscore(3);
employee1.Addscore(4);
employee1.Addscore(6);
employee1.Addscore(9);
employee1.Addscore(9);
employee2.Addscore(3);
employee2.Addscore(1);
employee2.Addscore(4);
employee2.Addscore(4);
employee2.Addscore(4);
employee3.Addscore(4);
employee3.Addscore(9);
employee3.Addscore(9);
employee3.Addscore(9);
employee3.Addscore(1);

List<Employee> gracze = new List<Employee>()
{
    employee1, employee2, employee3 
};
var maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (var employee in gracze)
{
    if (employee.Rating > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Rating;
    }
  
    }
    Console.WriteLine(employeeWithMaxResult.Name + " " +employeeWithMaxResult.Surname + " " +employeeWithMaxResult.Age + " "+"lat" +"-"+ maxResult+"punktów");

