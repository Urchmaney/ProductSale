using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySchoolMaterial.Models.AppViewModel
{
    public class DashboardViewModel
    {
        public string UserName { get; set; }

        public string Name { get; set; }

        public int NoOfMaterials { get; set; }

        public int NoOfFavMaterials { get; set; }

        public string Location { get; set; }

        public string Contact { get; set; }



        public List<Material> Materials { get; set; }

        public List<Material> AvailableRequestMaterials { get; set; }

        public List<Material> SoldRequestMaterial { get; set; }

        public List<Material> SoldMaterials { get; set; }
    }
}
