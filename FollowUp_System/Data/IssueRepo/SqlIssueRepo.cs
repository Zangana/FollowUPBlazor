using FollowUp_System.Model.IssueModel;
using FollowUp_System.Model.PagedResult;
using System.Net.Http.Json;


namespace FollowUp_System.Data.IssueRepo
{
    public class SqlIssueRepo : IIssueRepo
    {
        private readonly HttpClient _httpClient;

        public SqlIssueRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateIssue(IssueWrite issue)
        {
            if(issue == null)
            {
                return false;
            }
            if(issue.CfgIssueTypeId <= 0 || issue.TblWorkPlaceId <= 0)
            {
                return false;
            }

            var request = await _httpClient.PostAsJsonAsync("Issue/add", issue);
            return request.IsSuccessStatusCode;
        }

        public async Task<PagedResult<IssueRead>> GetAllIssues( int pageNumber = 1, int pageSize = 10)
        {
            var pagedIssueRead = new PagedResult<IssueRead>();
            var request = await _httpClient.GetAsync($"Issue/paged?currentPage={pageNumber}&pageSize={pageSize}");
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            if (request.IsSuccessStatusCode)
            {
                var data = await request.Content.ReadFromJsonAsync<PagedResult<IssueRead>>();
                if(data != null)
                {
                    return data;
                }
            }
            return pagedIssueRead;
        }

        public Task<IssueRead> GetIssueById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
