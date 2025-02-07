using System.ComponentModel;

namespace WideWorldImportersAPI.Resources
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public required string CustomerName { get; set; }
        public required int BillToCustomerId { get; set; }
        public required int CustomerCategoryId { get; set; }
        public required int PrimaryContactPersonId { get; set; }
        public required int DeliveryMethodId { get; set; }
        public required int DeliveryCityId { get; set; }
        public required int PostalCityId { get; set; }
        public required DateOnly AccountOpenedDate { get; set; }
        public required decimal StandardDiscountPercentage { get; set; }
        public required bool IsStatementSent { get; set; }
        public required bool IsOnCreditHold { get; set; }
        public required int PaymentDays { get; set; }
        public required string PhoneNumber { get; set; }
        public required string FaxNumber { get; set; }
        public required string WebsiteURL { get; set; }
        public required string DeliveryAddressLine1 { get; set; }
        public required string DeliveryPostalCode { get; set; }
        public required string PostalAddressLine1 { get; set; }
        public required string PostalPostalCode { get; set; }
        public required int LastEditedBy { get; set; }
        public required DateTime ValidFrom { get; set; }
        public required DateTime ValidTo { get; set; }
        public int? BuyingGroupId { get; set; }
        public int? AlternateContactPersonId { get; set; }
        public decimal? CreditLimit { get; set; }
        public string? DeliveryRun { get; set; }
        public string? RunPosition { get; set; }
        public string? DeliveryLocation { get; set; }
        public string? PostalAddressLine2 { get; set; }
        public string? DeliveryAddressLine2 { get; set; }
    }

}
