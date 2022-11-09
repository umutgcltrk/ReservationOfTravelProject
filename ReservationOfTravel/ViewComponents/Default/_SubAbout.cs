using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutRepository());
        public IViewComponentResult Invoke()
        {
            var listSubAboutContext = subAboutManager.GetAllList();
            return View(listSubAboutContext);
        }
    }
}
