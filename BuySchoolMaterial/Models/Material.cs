using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySchoolMaterial.Models
{
    public class Material
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CourseId { get; set; }

        public string Course { get; set; }

        public bool IsSold { get; set; }

        public bool IsFav { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime SoldDate { get; set; }

        public string OwnerId { get; set; }

        public ApplicationUser Owner { get; set; }
    }
}
