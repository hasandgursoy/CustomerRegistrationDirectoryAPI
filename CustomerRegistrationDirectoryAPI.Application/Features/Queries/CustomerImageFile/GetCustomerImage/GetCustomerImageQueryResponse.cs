namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.CustomerImageFile.GetCustomerImage
{
    public class GetCustomerImageQueryResponse
    {
        public string? Path { get; set; }
        public string? FileName { get; set; }
        public Guid Id { get; set; }
    }
}