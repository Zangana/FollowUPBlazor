using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FollowUp_System.Model.CfgUserProfileTypeModel;

namespace FollowUp_System.Model.UserProfileModel
{
    public partial class UserProfileRead
    {
        [Key]
        public long UserProfileId { get; set; }

        [StringLength(50)]
        public string? UserName { get; set; }

        public string? UserPassword { get; set; }

        public long? CfgUserProfileTypeId { get; set; }

        [ForeignKey("CfgUserProfileTypeId")]
        [InverseProperty("TblUserProfiles")]
        public virtual CfgUserProfileTypeRead? CfgUserProfileType { get; set; }
    }
}
