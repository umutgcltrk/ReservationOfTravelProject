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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _destinationDal;
        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }
        public void Add(Destination t)
        {
            _destinationDal.Add(t);
        }

        public List<Destination> GetAllList()
        {
            return _destinationDal.GetAllList();
        }

        public Destination GetTById(int id)
        {
            return _destinationDal.GetTById(id);
        }

        public void Remove(Destination t)
        {
            throw new NotImplementedException();
        }

        public void Update(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
