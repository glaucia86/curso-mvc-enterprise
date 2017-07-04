using AutoMapper;
using GL.AppEnterprise.Application.ViewModel;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            // Aqui estou realizando o mapeamente de ClientViewModel para Client 
            // Por ex.: ViewModel(ClientViewModel) -> Domain(Client)
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<ClientAddressViewModel, Client>();
            Mapper.CreateMap<ClientAddressViewModel, Address>();
            Mapper.CreateMap<AddressViewModel, Address>();
        }
    }
}