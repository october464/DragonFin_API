using Finportal.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    public class Invitation
    {
        public int Id { get; set; }

        public int HouseholdId { get; set; }

        public DateTimeOffset Created { get; set; }
        public DateTime Expires { get; set; }
        public bool Accepted { get; set; }

        public bool IsValid { get; set; }

        public string EmailTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }


        public PortalRole RoleName { get; set; }

        public Guid Code { get; set; }//check this whole class

    
    }
}
