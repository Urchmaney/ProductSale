using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BuySchoolMaterial.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        

        public string FullName { get; set; }

        public string Location { get; set; }

        public string Contact { get; set; }

        public List<Material> Materials { get; set; }
    }
}
