using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Oop
{
    public class Person
    {
        public string Name;
        public int age;

        public void ShowPerson()
        {
            Console.WriteLine($"Name: {Name}, Age: {age}");
        }
    }

    public class Employee : Person
    {
        public int EmployeeID;
        public string EmployeeDpet;


        public void showEmp()
        {
            Console.WriteLine($"EmployeeId: {EmployeeID}, Employee Department: {EmployeeDpet}");
        }
    }

    public class Manager : Employee
    {
       public string Responsiblity;
       public int teamsize;

       public void showManager()
        {
            Console.WriteLine($"Responsiblity: {Responsiblity}, Teamsize: {teamsize}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager mgr = new Manager();
            mgr.Name = "Azhar";
            mgr.age = 23;
            mgr.EmployeeID = 1;
            mgr.EmployeeDpet = "IT";
            mgr.Responsiblity = "Project Manager";
            mgr.teamsize = 26;


            Console.WriteLine("🔹 Manager Full Details:");
            mgr.ShowPerson();
            mgr.showEmp();
            mgr.showManager();
        }
    }
}
