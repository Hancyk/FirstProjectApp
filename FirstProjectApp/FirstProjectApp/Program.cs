
﻿using FirstProjectApp;

Employees Employee1 = new Employees("Wojtek", "Nowak", 32);
Employees Employee2 = new Employees("Ewa", "Kowalska", 28);
Employees Employee3 = new Employees("Michał", "Zając", 35);

Employee1.AddScore(5);
Employee1.AddScore(7);
Employee1.AddScore(4);
Employee1.AddScore(6);
Employee1.AddScore(2);

Employee2.AddScore(7);
Employee2.AddScore(8);
Employee2.AddScore(9);
Employee2.AddScore(7);
Employee2.AddScore(10);

Employee3.AddScore(6);
Employee3.AddScore(8);
Employee3.AddScore(9);
Employee3.AddScore(8);
Employee3.AddScore(7);

List<Employees> Employee = new List<Employees>()
{
    Employee1, Employee2, Employee3
};
int MaxResult = 0;
Employees EmployeesWithMaxResults = null;

foreach (var employees in Employee)
{ if (employees.Result > MaxResult)
    { MaxResult = employees.Result;
        EmployeesWithMaxResults = employees;
     }
 }
Console.WriteLine("Pracownik z największą ilościoą punktów (" + EmployeesWithMaxResults.Result + ") to:" + EmployeesWithMaxResults.Name +" "+ EmployeesWithMaxResults.Surname +" "+ EmployeesWithMaxResults.Age);
Console.WriteLine("Gratulacje!");

