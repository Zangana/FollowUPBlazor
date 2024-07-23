using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.CfgIssueTypeModel
{
    public class CfgIssueTypeRead
    {
        [Key]
        public long IssueTypeId { get; set; }

        [StringLength(50)]
        public string? IssueTypeName { get; set; }

        public long? CfgIssueTypeId { get; set; }

    }
}
