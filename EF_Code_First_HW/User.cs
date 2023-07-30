using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First_HW
{
    internal class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
