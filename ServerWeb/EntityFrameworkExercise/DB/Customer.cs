using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExercise.DB
{
    class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int Phone { get; set; }
        public string EMail { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
