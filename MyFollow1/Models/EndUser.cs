using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyFollow1.Models
{
    public class EndUser
    {
        [Key]
        public string emailID { get; set; }
        public DateTime DateOfJoin { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        public virtual ICollection<AppOwner> AppOwners { get; set; }    
    }
}