using DBTestsAppProj.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBTestsAppProj.Models
{
    public partial class Categorie : BaseEntity
    {
        public Categorie()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
