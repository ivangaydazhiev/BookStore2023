using BookStore.Models.Models;
using BookStore.Models.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Responses
{
    public class GetAllBooksByAuthorRespons
    {
        public  Author Author { get; set; } 

       public List<Book> Books {  get; set; } 
    }
}
