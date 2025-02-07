using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WideWorldImportersAPI.Resources
{
    public class CreateCustomerDto
    {
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
        public required DateTime ValidFrom { get; set; }
        public required DateTime ValidTo { get; set; }
    }

}
