using INJURY.DataAccess.Models;

using Microsoft.AspNetCore.Mvc;
using INJURY.Models;
using INJURY.DataAcess.Context;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace INJURY.Controllers
{
    public class InjuryController : Controller
    {
        private readonly SQLFundamentalsContext _context;

        public InjuryController(SQLFundamentalsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            InjuryViewModel model = new InjuryViewModel(_context);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int injuryid, string lastName, bool firstname, char address, string city, char injury)
        {
            InjuryViewModel model = new InjuryViewModel(_context);

            InjuryModels injury1 = new(injuryid, lastName, firstname, address, city, injury);

            model.SaveAccount(injury1);
            model.IsActionSuccess = true;
            model.ActionMessage = "Injury Information has been saved successfully";

            return View(model);
        }

        public IActionResult Update(int id)
        {
            InjuryViewModel model = new InjuryViewModel(_context, id);
            return View(model);
        }

        public IActionResult DeleteBanking(int id)
        {
            InjuryViewModel model = new InjuryViewModel(_context);

            if (id > 0)
            {
                model.RemoveAccount(id);
            }

            model.IsActionSuccess = true;
            model.ActionMessage = "Injury Information has been deleted successfully";
            return View("Index", model);
        }
    }
}



