using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Salary: {Salary}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee
            {
                ID = 1,
                Name = "keerthi",
                Salary = 10000
            };

            // Convert .NET object to JSON
            string json = JsonConvert.SerializeObject(employee);
            Console.WriteLine(json);

            // Convert JSON to .NET object
            var deserializedEmployee = JsonConvert.DeserializeObject<Employee>(json);
            Console.WriteLine(deserializedEmployee);
            Console.ReadLine();
        }
    }
}