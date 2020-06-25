namespace PlannerApp.Shared.Models
{
    public abstract class BaseAPIResponse
    {
        public string message { get; set; }

        public bool isSuccess { get; set; }
    }

         
}
