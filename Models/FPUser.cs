using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonFin_API.Models
{
    public class FPUser : IdentityUser
    {
     
        public string FirstName { get; set; }

      
        public string LastName { get; set; }

    

   
        public IFormFile FormFile { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public int? HouseholdId { get; set; }

    }
}
