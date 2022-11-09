using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _FeatureHeaders : ViewComponent
    {
        FeatureHeaderManager featureHeaderManager = new FeatureHeaderManager(new EfFeatureHeaderRepository());
        public IViewComponentResult Invoke()
        {
            var listFeatureHeader = featureHeaderManager.GetAllList();
            return View(listFeatureHeader);
        }
    }
}
