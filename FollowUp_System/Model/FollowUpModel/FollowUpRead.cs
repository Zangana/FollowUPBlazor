using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.FollowUpModel
{
    public partial class FollowUpRead
    {
        [Key]
        public long FollowUpId { get; set; }

        public string? FollowUpNote { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime? FollowUpDate { get; set; }


        public byte? TblFollowUpDone { get; set; }

        public long? CfgFollowUpType { get; set; }

    }
}
