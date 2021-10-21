using RestAPIDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestAPIDDD.Application.Interfaces {

    public interface IApplicationServiceCliente {

        void Add(ClienteDTO clienteDTO);

        void Update(ClienteDTO clienteDTO);

        void Remove(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> GetAll();

        ClienteDTO GetById(int id);
    }
}