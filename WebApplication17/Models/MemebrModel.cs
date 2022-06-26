using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppliaction17.Models
{
    public class MemberModel
    {
        public string Name { get; set; }
        public string designation { get; set; }
        public string ImagePath { get; set; }
        public HttpPostedFile ImageFile { get; set; }
    }
}