using AspNetCore.Identity.MongoDbCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Models.Users
{
    public class IdentityUser : MongoIdentityUser<Guid>
    {
        public IdentityUser()  
        {
        
        }

        public IdentityUser(string userName, string password) : base(userName, password) 
        {

        }
        public string AuthorId { get; set; } = string.Empty;
    }
}
