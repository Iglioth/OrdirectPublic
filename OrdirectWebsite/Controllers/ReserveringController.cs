using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OrdirectWebsite
{
    public class ReserveringController : Controller
    {
        ReserveringRepository repo;
        IReserveringContext context;

        public ReserveringController()
        {
            context = new ReserveringMSSQLContext();
            repo = new ReserveringRepository(context);
        }

        [HttpGet]
        public IActionResult Index(int id)
        {
            ReserveringViewModel vm = new ReserveringViewModel();
            vm = repo.GetReserveringById(string id);
            return View(vm);
        }
    }
}
