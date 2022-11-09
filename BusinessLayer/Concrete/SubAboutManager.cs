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
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }
        public void Add(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetAllList()
        {
            return _subAboutDal.GetAllList();
        }

        public SubAbout GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void Update(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
