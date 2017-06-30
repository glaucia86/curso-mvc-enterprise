using System;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        Client Add(Client client);
    }
}