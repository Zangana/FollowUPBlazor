using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.IssueModel
{
    public class IssueWrite
    {


        public string? IssueNote { get; set; }

        public long? TblWorkPlaceId { get; set; }

        public long? CfgIssueTypeId { get; set; }

    }
}
