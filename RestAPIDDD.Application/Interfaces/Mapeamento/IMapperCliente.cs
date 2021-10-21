using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestAPIDDD.Application.Interfaces.Mapeamento {

    public interface IMapperCliente {

        Cliente MapperDTOToEntity(ClienteDTO clienteDTO);

        IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes);

        ClienteDTO MapperEntityToDTO(Cliente cliente);
    }
}