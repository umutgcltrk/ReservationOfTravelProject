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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public void Add(Comment t)
        {
            _commentDal.Add(t);
        }

        public List<Comment> GetAllList()
        {
            return _commentDal.GetAllList();
        }

        public List<Comment> GetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(x => x.DestinationId == id);
        }

        public Comment GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
