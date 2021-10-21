﻿using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Application.Interfaces;
using RestAPIDDD.Application.Interfaces.Mapeamento;
using RestAPIDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestAPIDDD.Application {

    public class ApplicationServiceProduto : IApplicationServiceProduto {
        private readonly IServiceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto) {
            this.serviceProduto = serviceProduto;
            this.mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDTO produtoDTO) {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDTO> GetAll() {
            var produtos = serviceProduto.GetAll();
            return mapperProduto.MapperListProdutosDTO(produtos);
        }

        public ProdutoDTO GetById(int id) {
            var produto = serviceProduto.GetById(id);
            return mapperProduto.MapperEntityToDTO(produto);
        }

        public void Remove(ProdutoDTO produtoDTO) {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDTO produtoDTO) {
            var produto = mapperProduto.MapperDTOToEntity(produtoDTO);
            serviceProduto.Update(produto);
        }
    }
}