using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ReservationOfTravel.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialRepository());
        public IViewComponentResult Invoke()
        {
            var listTestimonials = testimonialManager.GetAllList();
            return View(listTestimonials);
        }
    }
}
