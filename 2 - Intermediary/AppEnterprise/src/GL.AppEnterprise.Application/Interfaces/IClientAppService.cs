using System;
using System.Collections;
using System.Collections.Generic;
using GL.AppEnterprise.Application.ViewModel;
using GL.AppEnterprise.Domain.Entities;

namespace GL.AppEnterprise.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {

        //Método responsável por 'Adicionar' um novo Cliente e um Endereço (ambos)
        ClientAddressViewModel Add(ClientAddressViewModel clientAddressViewModel);

        // Método responsável por retornar um determinado cliente pelo 'Id'
        ClientViewModel GetById(Guid id);

        // Método responsável por retornar um determinado cliente pelo 'CPF'
        ClientViewModel GetByCpf(string cpf);


        // Método responsável por retornar um determinado 'E-mail' de um Cliente
        ClientViewModel GetByEmail(string email);

        // Método responsável por retornar todos os clientes
        IEnumerable<ClientViewModel> GetAll();

        // Método responsável por atualizar um determinado Cliente
        ClientViewModel Update(ClientViewModel clientViewModel);

        // Método responsável por excluir um determinado 'Cliente' pelo id
        void Delete(Guid id);
    }
}