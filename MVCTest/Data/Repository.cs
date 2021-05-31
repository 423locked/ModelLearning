using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Data
{
    public class Repository
    {
        private static List<string> names;
        private static Random r;
        static Repository()
        {
            names = new List<string>() { "Mike", "Michelle", "Alina", "Bob", "Margo", "Alex", "Sue", "Megan" };
            r = new Random();
        }

        public static Worker GetWorker()
        {
            string name = names[r.Next(names.Count)];
            int salary = r.Next(8000,15000);
            int age = r.Next(18, 90);
            return new Worker()
            {
                Age = age,
                Salary = salary,
                Name = name
            };
        }

        public static List<Worker> GetWorkers(int n)
        {
            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < n; i++)
                workers.Add(GetWorker());
            return workers;
        }
    }
}
