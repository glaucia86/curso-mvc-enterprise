using System;
using System.Collections.Generic;
using GL.AppEnterprise.Application.Interfaces;
using GL.AppEnterprise.Application.ViewModel;
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
            throw new NotImplementedException();
        }

        public ClientViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ClientViewModel GetByCpf(string cpf)
        {
            throw new NotImplementedException();
        }

        public ClientViewModel GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ClientViewModel Update(ClientViewModel clientViewModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}