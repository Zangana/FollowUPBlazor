using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.CfgFollowUpTypeModel
{
    public class CfgFollowUpTypeWrite
    {

        [StringLength(50)]
        public string? FollowUpTypeName { get; set; }
    }
}
