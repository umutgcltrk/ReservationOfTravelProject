using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
