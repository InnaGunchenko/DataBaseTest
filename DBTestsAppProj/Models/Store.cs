using DBTestsAppProj.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBTestsAppProj.Models
{
    public partial class Store : BaseEntity
    {
        public Store()
        {
            Orders = new HashSet<Order>();
            Staffs = new HashSet<Staff>();
            Stocks = new HashSet<Stock>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
