using System;
using ContratoTrabalhadores.Entities.Enums;
using ContratoTrabalhadores.Entities;
using System.Globalization;

namespace ContratoTrabalhadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

        }
    }
}
