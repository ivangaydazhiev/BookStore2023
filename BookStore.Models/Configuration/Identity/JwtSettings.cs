using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Configuration.Identity
{
    public class JwtSettings
    {
        public string Secret { get; set; } = String.Empty;
    }
}
