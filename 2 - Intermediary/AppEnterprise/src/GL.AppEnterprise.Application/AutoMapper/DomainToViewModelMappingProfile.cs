using AutoMapper;
using GL.AppEnterprise.Application.ViewModel;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            // Aqui estou realizando o mapeamente de Client para ClientViewModel
            // Por ex.: Domain(Client) -> ViewModel(ClientViewModel)
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Client, ClientAddressViewModel>();
            Mapper.CreateMap<Address, AddressViewModel>();
            Mapper.CreateMap<Address, ClientAddressViewModel>();
        }
    }
}