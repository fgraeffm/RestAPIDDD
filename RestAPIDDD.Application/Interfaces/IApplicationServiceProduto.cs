using RestAPIDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestAPIDDD.Application.Interfaces {

    public interface IApplicationServiceProduto {

        void Add(ProdutoDTO produtoDTO);

        void Update(ProdutoDTO produtoDTO);

        void Remove(ProdutoDTO produtoDTO);

        IEnumerable<ProdutoDTO> GetAll();

        ProdutoDTO GetById(int id);
    }
}