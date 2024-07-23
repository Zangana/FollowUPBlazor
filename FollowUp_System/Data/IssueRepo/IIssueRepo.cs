using FollowUp_System.Model.IssueModel;
using FollowUp_System.Model.PagedResult;

namespace FollowUp_System.Data.IssueRepo
{
    public interface IIssueRepo
    {
        Task<PagedResult<IssueRead>> GetAllIssues(int pageNumber = 1, int pageSize = 10);
        Task<IssueRead> GetIssueById(long id);
        Task<bool> CreateIssue(IssueWrite issue);
    }
}
