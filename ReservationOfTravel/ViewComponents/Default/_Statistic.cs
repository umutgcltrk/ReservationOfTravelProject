using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _Statistic : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new DatabaseContext();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            ViewBag.v4 = "568";
            return View();
        }
    }
}
