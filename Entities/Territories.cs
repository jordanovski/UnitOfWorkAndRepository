namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Territories : IObjectState
    {
        public Territories()
        {
            Employees = new List<Employees>();
        }

        [Key]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }

        public virtual Region Region { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
