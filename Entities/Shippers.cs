namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Shippers : IObjectState
    {
        public Shippers()
        {
            Orders = new List<Orders>();
        }

        [Key]
        public int ShipperID { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
