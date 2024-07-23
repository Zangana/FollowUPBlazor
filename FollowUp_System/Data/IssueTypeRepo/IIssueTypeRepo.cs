using FollowUp_System.Model.CfgIssueTypeModel;

namespace FollowUp_System.Data.IssueTypeRepo
{
    public interface IIssueTypeRepo
    {
        Task<IEnumerable<CfgIssueTypeRead>> getAll();
        Task<CfgIssueTypeRead> getById(long id);
        Task<CfgIssueTypeRead> create(CfgIssueTypeWrite issueType);
    }
}
