namespace MVCWEBUI.Models
{
    public class ResponseComing<T>
    {
        public List<T> data { get; set; }
        public List<string> errorMessage { get; set; }
        public List<string> successMessage { get; set; }

    }
}
