using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Application.Interfaces.Mapeamento;
using RestAPIDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIDDD.Application.Mapeamento {

    public class MapperCliente : IMapperCliente {

        public Cliente MapperDTOToEntity(ClienteDTO clienteDTO) {
            var cliente = new Cliente() {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email
            };

            return cliente;
        }

        public ClienteDTO MapperEntityToDTO(Cliente cliente) {
            var clienteDTO = new ClienteDTO {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };

            return clienteDTO;
        }

        public IEnumerable<ClienteDTO> MapperListClientesDTO(IEnumerable<Cliente> clientes) {
            var dto = clientes.Select(c => new ClienteDTO {
                Id = c.Id,
                Nome = c.Nome,
                Sobrenome = c.Sobrenome,
                Email = c.Email
            });

            return dto;
        }
    }
}