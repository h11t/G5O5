using System;
using System.Collections.Generic;
using System.Text;

namespace G5O5.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string TCNo { get; set; }
    }
}
