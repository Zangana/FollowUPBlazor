namespace FollowUp_System.Model.PagedResult
{
    public class PagedResult<T>
    {
        public List<T> Results { get; set; } = new List<T>();
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }

        public int PageSize { get; set; }

    }
}
