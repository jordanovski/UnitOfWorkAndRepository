namespace Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Region")]
    public partial class Region : IObjectState
    {
        public Region()
        {
            Territories = new List<Territories>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }

        [Required]
        [StringLength(50)]
        public string RegionDescription { get; set; }

        public virtual ICollection<Territories> Territories { get; set; }

        [NotMapped]
        public ObjectState State { get; set; }
    }
}
