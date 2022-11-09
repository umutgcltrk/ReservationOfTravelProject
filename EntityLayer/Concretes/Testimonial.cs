using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Client { get; set; }
        public string ClientComment { get; set; }
        public string ClientImage { get; set; }
        public bool ClientStatus { get; set; }
    }
}
