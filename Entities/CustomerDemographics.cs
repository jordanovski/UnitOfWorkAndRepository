namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CustomerDemographics : IObjectState
    {
        public CustomerDemographics()
        {
            Customers = new List<Customers>();
        }

        [Key]
        [StringLength(10)]
        public string CustomerTypeID { get; set; }

        [Column(TypeName = "ntext")]
        public string CustomerDesc { get; set; }

        public virtual ICollection<Customers> Customers { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
