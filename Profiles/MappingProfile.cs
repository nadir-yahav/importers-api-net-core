using AutoMapper;
using WideWorldImportersAPI.Models;
using WideWorldImportersAPI.Resources;

namespace WideWorldImportersAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
            CreateMap<CreateCustomerDto, Customer>();
            CreateMap<UpdateCustomerDto, Customer>();
            
        }
    }
}
