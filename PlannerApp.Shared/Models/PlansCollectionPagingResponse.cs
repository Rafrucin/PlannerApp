namespace PlannerApp.Shared.Models
{
    public class PlansCollectionPagingResponse : BaseAPIResponse
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int? nextPage { get; set; }
        public Plan[] Records { get; set; }
        public int count { get; set; }
        //public DateTime operationDate { get; set; }
    }

         
}
