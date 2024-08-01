using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.CfgUserProfileTypeModel
{
    public class CfgUserProfileTypeRead
    {
        [Key]
        public long UserProfileTypeId { get; set; }

        [StringLength(20)]
        public string? UserProfileTypeName { get; set; }
    }
}
