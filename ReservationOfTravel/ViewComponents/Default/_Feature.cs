using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureRepository());
        public IViewComponentResult Invoke()
        {
            
            var listFeatures = featureManager.GetAllList();
            return View(listFeatures);
        }
    }
}
