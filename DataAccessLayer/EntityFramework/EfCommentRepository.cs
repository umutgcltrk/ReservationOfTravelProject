using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    /*ICommentDal implementation istemiyor çünkü implemantationları GenericRepository yaptı.*/
    public class EfCommentRepository : GenericRepository<Comment>,ICommentDal
    {
        
    }
}
