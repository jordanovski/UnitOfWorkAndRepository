namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Orders : IObjectState
    {
        public Orders()
        {
            Order_Details = new List<OrderDetails>();
        }

        [Key]
        public int OrderID { get; set; }

        [StringLength(5)]
        public string CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public DateTime? OrderDate { get; set; }

        public DateTime? RequiredDate { get; set; }

        public DateTime? ShippedDate { get; set; }

        public int? ShipVia { get; set; }

        [Column(TypeName = "money")]
        public decimal? Freight { get; set; }

        [StringLength(40)]
        public string ShipName { get; set; }

        [StringLength(60)]
        public string ShipAddress { get; set; }

        [StringLength(15)]
        public string ShipCity { get; set; }

        [StringLength(15)]
        public string ShipRegion { get; set; }

        [StringLength(10)]
        public string ShipPostalCode { get; set; }

        [StringLength(15)]
        public string ShipCountry { get; set; }

        public virtual Customers Customers { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual ICollection<OrderDetails> Order_Details { get; set; }

        public virtual Shippers Shippers { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
