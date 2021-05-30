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
        public string Index()
        {
            Worker worker = Repository.GetWorker();

            string output = $"The worker {worker.Name} is {worker.Age} y.o. and has a salary of {worker.Salary}$.";

            return output;
        }
    }
}
