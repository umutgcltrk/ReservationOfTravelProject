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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;
        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void Add(Feature t)
        {
            throw new NotImplementedException();
        }

        public List<Feature> GetAllList()
        {
            return _featureDal.GetAllList();
        }

        public Feature GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Feature t)
        {
            throw new NotImplementedException();
        }

        public void Update(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
