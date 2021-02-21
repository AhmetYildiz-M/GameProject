using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Concrete;

namespace GameProject.Entities
{
    public class Order : IEntity
    {
        public string Id { get; set; }
        public string NationalityId { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderPrice { get; set; }
        
    }
}
