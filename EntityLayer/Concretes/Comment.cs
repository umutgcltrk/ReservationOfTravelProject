using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentUser { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
