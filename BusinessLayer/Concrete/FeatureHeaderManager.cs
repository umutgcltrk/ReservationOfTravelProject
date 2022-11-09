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
    public class FeatureHeaderManager : IFeatureHeaderService
    {
        IFeatureHeaderDal _featureHeaderDal;
        public FeatureHeaderManager(IFeatureHeaderDal featureHeaderDal)
        {
            _featureHeaderDal = featureHeaderDal;
        }

        public void Add(FeatureHeader t)
        {
            throw new NotImplementedException();
        }

        public List<FeatureHeader> GetAllList()
        {
            return _featureHeaderDal.GetAllList();
        }

        public FeatureHeader GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(FeatureHeader t)
        {
            throw new NotImplementedException();
        }

        public void Update(FeatureHeader t)
        {
            throw new NotImplementedException();
        }
    }
}
