namespace CustomerRegistrationDirectoryAPI.Application.Features.Queries.Trade.GetByIdTrade
{
    public class GetByIdTradeQueryResponse
    {
        public Guid CustomerId { get; set; }
        public Domain.Entities.Customer Customer { get; set; }
        public string Description { get; set; }
        public decimal TradeVolume { get; set; }
    }
}