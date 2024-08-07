using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FollowUp_System.Model.CfgIssueTypeModel;
using FollowUp_System.Model.WorkPlaceModel;
using FollowUp_System.Model.FollowUpModel;

namespace FollowUp_System.Model.IssueModel
{
    public class IssueRead
    {
        [Key]
        public long IssueId { get; set; }


        public string? IssueNote { get; set; }

        public long? TblWorkPlaceId { get; set; }

        [ForeignKey("CfgIssueTypeId")]
        [InverseProperty("TblIssues")]
        public virtual CfgIssueTypeRead? CfgIssueType { get; set; }

        [InverseProperty("TblIssue")]
        public virtual ICollection<FollowUpRead> TblFollowUps { get; set; } = new List<FollowUpRead>();

        [ForeignKey("TblWorkPlaceId")]
        [InverseProperty("TblIssues")]
        public virtual WorkPlaceRead? TblWorkPlace { get; set; }
    }
}
