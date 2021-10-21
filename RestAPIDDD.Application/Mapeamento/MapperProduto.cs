using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Application.Interfaces.Mapeamento;
using RestAPIDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestAPIDDD.Application.Mapeamento {

    public class MapperProduto : IMapperProduto {

        public Produto MapperDTOToEntity(ProdutoDTO produtoDTO) {
            var produto = new Produto {
                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor
            };

            return produto;
        }

        public ProdutoDTO MapperEntityToDTO(Produto produto) {
            var produtoDTO = new ProdutoDTO {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };

            return produtoDTO;
        }

        public IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos) {
            var dto = produtos.Select(c => new ProdutoDTO {
                Id = c.Id,
                Nome = c.Nome,
                Valor = c.Valor
            });

            return dto;
        }
    }
}