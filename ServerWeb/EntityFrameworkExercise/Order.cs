using System;
using System.Collections.Generic;

namespace EntityFrameworkExercise
{
    class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public ICollection<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
