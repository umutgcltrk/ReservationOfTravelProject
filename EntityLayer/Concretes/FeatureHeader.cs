using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class FeatureHeader
    {
        public int FeatureHeaderId { get; set; }
        public string HeaderTitle { get; set; }
        public string HeaderPostDescription { get; set; }
        public string HeaderPostImage { get; set; }
        public bool HeaderPostStatus { get; set; }
    }
}
