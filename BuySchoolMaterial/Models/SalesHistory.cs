using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuySchoolMaterial.Models
{
    public class SalesHistory
    {
        public int Id { get; set; }

        public int RequestId { get; set; }

        public int MaterialId { get; set; }

        public string RequsterId { get; set; }

        public string OwnerId { get; set; }

        public string Requester { get; set; }

        public string Owner { get; set; }
    }
}
