using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_waste_food
{
    /* To register Resturant & Hotels */

    public class Vendor
    {
        public int Id { get; set; }
        public string VendorPassword { get; set; }
        public string VendorAddress { get; set; }
        public string VendorMail { get; set; }
        public string VendorPhone { get; set; }
        public string VendorName { get; set; }
        public string VendorType { get; set; }
        public string VendorId { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }           // This means that a vendor can advertise ( post ) many Orders
        public virtual IEnumerable<Customer> Customers { get; set; }     // This means that a vendor can advertise ( post ) to many customers

    }
}
