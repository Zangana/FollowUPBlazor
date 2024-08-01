using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.CfgUserProfileTypeModel
{
    public class CfgUserProfileTypeWrite
    {

        [StringLength(20)]
        public string? UserProfileTypeName { get; set; }
    }
}
