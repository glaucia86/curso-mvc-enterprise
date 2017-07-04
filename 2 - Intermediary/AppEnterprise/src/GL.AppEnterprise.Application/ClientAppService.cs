using System;
using System.Collections.Generic;
using AutoMapper;
using GL.AppEnterprise.Application.Interfaces;
using GL.AppEnterprise.Application.ViewModel;
using GL.AppEnterprise.Domain.Entities;
using GL.AppEnterprise.Infra.Data.Repositories;

namespace GL.AppEnterprise.Application
{
    public class ClientAppService : IClientAppService
    {
        private readonly ClientRepository _clientRepository;

        public ClientAppService()
        {
            _clientRepository = new ClientRepository();
        }
        
        public ClientAddressViewModel Add(ClientAddressViewModel clientAddressViewModel)
        {
            // Primeiro: Precisamos mapear os dados de Client e Address de Client
            var client = Mapper.Map<ClientAddressViewModel, Client>(clientAddressViewModel);
            
            // Segundo: Realizar o mapeamento de Endereço também
            var address = Mapper.Map<ClientAddressViewModel, Address>(clientAddressViewModel);

            // Terceiro: Adicionar os dados de Endereço pelo cliente
            client.Addresses.Add(address);

            // Quarto: Adicionar os dados mapeados
            _clientRepository.Add(client);

            // Quinto: Retornar os valores
            return clientAddressViewModel;
        }

        public ClientViewModel GetById(Guid id)
        {
            return Mapper.Map<Client, ClientViewModel>(_clientRepository.GetById(id));
        }

        public ClientViewModel GetByCpf(string cpf)
        {
            return Mapper.Map<Client, ClientViewModel>(_clientRepository.GetByCpf(cpf));
        }

        public ClientViewModel GetByEmail(string email)
        {
            return Mapper.Map<Client, ClientViewModel>(_clientRepository.GetByEmail(email));
        }

        public IEnumerable<ClientViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientRepository.GetAll());
        }

        public ClientViewModel Update(ClientViewModel clientViewModel)
        {
            _clientRepository.Update(Mapper.Map<ClientViewModel, Client>(clientViewModel));
            return clientViewModel;
        }

        public void Delete(Guid id)
        {
            _clientRepository.Delete(id);
        }

        public void Dispose()
        {
            _clientRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}