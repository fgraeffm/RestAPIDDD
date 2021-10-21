using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestAPIDDD.Application.Interfaces.Mapeamento {

    public interface IMapperProduto {

        Produto MapperDTOToEntity(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> MapperListProdutosDTO(IEnumerable<Produto> produtos);

        ProdutoDTO MapperEntityToDTO(Produto produto);
    }
}