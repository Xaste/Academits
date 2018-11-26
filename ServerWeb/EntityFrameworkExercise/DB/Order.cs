using System;
using System.Collections.Generic;

namespace EntityFrameworkExercise.DB
{
    class Order
    {
        public int Id { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<Product> Products { get; set; } = new List<Product>();

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
