using FollowUp_System.Model.WorkPlaceModel;
using System.Net.Http.Json;

namespace FollowUp_System.Data.WorkPlaceRepo
{
    public class SqlWorkPlaceRepo : IWorkPlaceRepo
    {
        private readonly HttpClient _httpClient;

        public SqlWorkPlaceRepo(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<WorkPlaceRead>> GetAll()
        {
            var request = await _httpClient.GetAsync("WorkPlace");
            if(request.IsSuccessStatusCode)
            {
                var data = await request.Content.ReadFromJsonAsync<IEnumerable<WorkPlaceRead>>();
                if(data != null)
                {
                    return data;
                }
            }
            return new List<WorkPlaceRead>();
        }

        public Task<WorkPlaceRead> GetById(long id)
        {
            throw new NotImplementedException();
        }
    }
}
