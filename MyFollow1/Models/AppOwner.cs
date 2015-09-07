using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow1.Models
{

    public class AppOwner
    {
        [Key]
        public string emailID { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string FoundedIn { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public string TwitterHandler { get; set; }
        public string FacebookUrl { get; set; }
        public virtual EndUser EndUsers { get; set; }

    }
}