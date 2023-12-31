﻿namespace JWTAppBackOffice.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }

        //Nav Props
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}
