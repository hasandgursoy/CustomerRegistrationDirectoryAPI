namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerQueryResponse
    {
        public int TotalCount { get; set; }
        public object Customers { get; set; }
    }
}