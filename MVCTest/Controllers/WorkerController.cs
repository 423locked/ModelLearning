using Microsoft.AspNetCore.Mvc;
using MVCTest.Data;
using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Controllers
{
    public class WorkerController : Controller
    {
        public IActionResult Index()
        {
            List<Worker> workers = Repository.GetWorkers(15);

            return View(workers);
        }

        public string getDataFromViewField(string Name, int Age, int Salary)
        {
            return $"{Name} is {Age} years old and has a salary of {Salary}.";
        }

        public Worker getWorkerFromViewField(Worker worker)
        {
            return new Worker() { Age = worker.Age, Name = worker.Name, Salary = worker.Salary };
        }

        public List<Worker> getListOfWorkers(List<Worker> workers)
        {
            return workers;
        }
    }
}
