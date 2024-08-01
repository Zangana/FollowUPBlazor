using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FollowUp_System.Model.FollowUpModel
{
    public class FollowUpWrite
    {

        public string? FollowUpNote { get; set; }


        [Column(TypeName = "datetime")]
        public DateTime? FollowUpDate { get; set; }


        public byte? TblFollowUpDone { get; set; }

        public long? CfgFollowUpType { get; set; }

    }
}
