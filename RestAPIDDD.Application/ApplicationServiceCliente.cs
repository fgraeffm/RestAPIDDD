using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Application.Interfaces;
using RestAPIDDD.Application.Interfaces.Mapeamento;
using RestAPIDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestAPIDDD.Application {

    public class ApplicationServiceCliente : IApplicationServiceCliente {
        private readonly IServiceCliente serviceCliente;
        private readonly IMapperCliente mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente) {
            this.serviceCliente = serviceCliente;
            this.mapperCliente = mapperCliente;
        }

        public void Add(ClienteDTO clienteDTO) {
            var cliente = mapperCliente.MapperDTOToEntity(clienteDTO);
            serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDTO> GetAll() {
            var clientes = serviceCliente.GetAll();
            return mapperCliente.MapperListClientesDTO(clientes);
        }

        public ClienteDTO GetById(int id) {
            var cliente = serviceCliente.GetById(id);
            return mapperCliente.MapperEntityToDTO(cliente);
        }

        public void Remove(ClienteDTO clienteDTO) {
            var cliente = mapperCliente.MapperDTOToEntity(clienteDTO);
            serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDTO clienteDTO) {
            var cliente = mapperCliente.MapperDTOToEntity(clienteDTO);
            serviceCliente.Update(cliente);
        }
    }
}