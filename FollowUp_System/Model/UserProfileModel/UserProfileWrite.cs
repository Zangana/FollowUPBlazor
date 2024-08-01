using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.UserProfileModel
{
    public class UserProfileWrite
    {

        [StringLength(50)]
        public string? UserName { get; set; }

        public string? UserPassword { get; set; }

        public long? CfgUserProfileTypeId { get; set; }


    }
}
