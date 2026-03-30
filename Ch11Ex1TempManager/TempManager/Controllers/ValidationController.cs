using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TempManager.Models;
namespace TempManager.Controllers
{ 
    public class ValidationController : Controller
    {
        private TempManagerContext data { get; set; }
        public ValidationController(TempManagerContext context) { 
            data = context;
        }

        public JsonResult CheckDate(DateTime? date)
        {
            if (date == null) {
                return Json("Please enter a date.");
            }

            string msg = data.Temps.FirstOrDefault(t => t.Date == date) == null ? "" : "A record with that date already exists.";
            if (string.IsNullOrEmpty(msg)) {
                return Json(true);
            } else {
                return Json(msg);
            }
        }
    }
}
