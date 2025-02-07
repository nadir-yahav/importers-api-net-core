using System.ComponentModel;

namespace WideWorldImportersAPI.Resources
{
    public class UpdateCustomerDto
    {
        public int CustomerId { get; set; }
        public required string CustomerName { get; set; }
        [DefaultValue(1)]
        public required int BillToCustomerId { get; set; }
        [DefaultValue(1)]
        public required int CustomerCategoryId { get; set; }
        [DefaultValue(1)]
        public required int PrimaryContactPersonId { get; set; }
        [DefaultValue(1)]
        public required int DeliveryMethodId { get; set; }
        [DefaultValue(1)]
        public required int DeliveryCityId { get; set; }
        [DefaultValue(1)]
        public required int PostalCityId { get; set; }
        public required DateOnly AccountOpenedDate { get; set; }
        public required decimal StandardDiscountPercentage { get; set; }
        public required bool IsStatementSent { get; set; }
        public required bool IsOnCreditHold { get; set; }
        [DefaultValue(1)]
        public required int PaymentDays { get; set; }
        public required string PhoneNumber { get; set; }
        public required string FaxNumber { get; set; }
        public required string WebsiteURL { get; set; }
        public required string DeliveryAddressLine1 { get; set; }
        public required string DeliveryPostalCode { get; set; }
        public required string PostalAddressLine1 { get; set; }
        public required string PostalPostalCode { get; set; }
        [DefaultValue(1)]
        public required int LastEditedBy { get; set; }
        [DefaultValue(1)]
        public int? AlternateContactPersonId { get; set; }
        public string? DeliveryLocation { get; set; }
        public string? PostalAddressLine2 { get; set; }
        public string? DeliveryAddressLine2 { get; set; }
    }
}
