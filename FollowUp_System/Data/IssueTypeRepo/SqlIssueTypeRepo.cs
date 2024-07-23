using FollowUp_System.Model.CfgIssueTypeModel;
using System.Net.Http.Json;

namespace FollowUp_System.Data.IssueTypeRepo
{
    public class SqlIssueTypeRepo : IIssueTypeRepo
    {
        private readonly HttpClient _httpClient;

        public SqlIssueTypeRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<CfgIssueTypeRead> create(CfgIssueTypeWrite issueType)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CfgIssueTypeRead>> getAll()
        {
            var request = await _httpClient.GetAsync("CfgIssueType");
            request.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            if (request.IsSuccessStatusCode)
            {
                var data = await request.Content.ReadFromJsonAsync<IEnumerable<CfgIssueTypeRead>>();
                if (data != null)
                {
                    return data;
                }
            }
            return new List<CfgIssueTypeRead>();
        }

        public Task<CfgIssueTypeRead> getById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
