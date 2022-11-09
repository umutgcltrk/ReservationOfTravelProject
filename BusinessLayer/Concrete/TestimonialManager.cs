using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        ITestimonialDal _testimonialDal;
        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }
        public void Add(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> GetAllList()
        {
            return _testimonialDal.GetAllList();
        }

        public Testimonial GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void Update(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
