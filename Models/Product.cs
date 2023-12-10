using System;
using System.Collections.Generic;

namespace Store.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public Boolean IsDeleted { get; set; }

        public int CreatorUserId { get; set; }
        public string ImageUrl { get; set; }
    }
}