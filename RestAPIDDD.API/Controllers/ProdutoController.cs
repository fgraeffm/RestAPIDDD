using Microsoft.AspNetCore.Mvc;
using RestAPIDDD.Application.DTOs;
using RestAPIDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestAPIDDD.API.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase {
        private readonly IApplicationServiceProduto applicationServiceProduto;

        public ProdutoController(IApplicationServiceProduto applicationServiceProduto) {
            this.applicationServiceProduto = applicationServiceProduto;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get() {
            return Ok(applicationServiceProduto.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id) {
            return Ok(applicationServiceProduto.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDTO produtoDTO) {
            try {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            } catch (Exception ex) {
                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDTO produtoDTO) {
            try {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");
            } catch (Exception ex) {
                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDTO produtoDTO) {
            try {
                if (produtoDTO == null)
                    return NotFound();

                applicationServiceProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}