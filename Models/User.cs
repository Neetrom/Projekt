using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Models
{

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Age { get; set; }
        public Boolean Is_deleted { get; set; }
        public Boolean Is_admin { get; set; }

        public ICollection<Product> Product_ID { get; set; }
    }
}