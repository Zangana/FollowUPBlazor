using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.CfgFollowUpTypeModel
{
    public class CfgFollowUpTypeRead
    {
        [Key]
        public long FollowUpTypeId { get; set; }

        [StringLength(50)]
        public string? FollowUpTypeName { get; set; }
    }
}
