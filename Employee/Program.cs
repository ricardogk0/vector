using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee will be registred? ");
            int op = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 1; i <= op; i++)
            {
                Console.Write("Employee #" + i + "\n\rId:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                
                list.Add(new Employees(id, name, salary));
            }

            Console.Write("Enter employee Id that will have salary increase: ");
            int seach = int.Parse(Console.ReadLine());

            Employees emp = list.Find(x => x.Id == seach);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }
            else
                Console.Write("Id do not exists.");

            Console.WriteLine("Update list of the employees: ");

            foreach(Employees obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}