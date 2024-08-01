using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.WorkPlaceModel
{
    public class WorkPlaceRead
    {
        [Key]
        public long WorkPlaceId { get; set; }

        [StringLength(50)]
        public string? WorkPlaceName { get; set; }

        [StringLength(12)]
        public string? WorkPlacePhoneNumber { get; set; }

        [StringLength(20)]
        public string? WorkPlaceTypeOfCompany { get; set; }

    }
}
