using Microsoft.AspNetCore.Mvc;

namespace CustomersManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Método para Inserir novos clientes
        /// </summary>
        /// <param name="customer">Objeto contendo informações do cliente</param>
        /// <returns>Retorna status code 201 se executado com sucesso, caso contrário retorna 409</returns>
        [HttpPost]
        public ActionResult<string> Post([FromBody] Business.DTOs.CustomerDTO customer)
        {
            bool result = Business.Customer.Insert(customer);

            if (result)
                return (StatusCode(201));
            else
                return (StatusCode(409));
        }

        /// <summary>
        /// Método para retornar todos os clientes
        /// </summary>
        /// <returns>Retorna uma lista com todos os clientes</returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            return (Ok(Business.Customer.GetAll()));
        }

        /// <summary>
        /// Método para buscar o cliente com o id desejado
        /// </summary>
        /// <param name="id">Id do cliente desejado</param>
        /// <returns>Retorna o cliente com o id desejado, caso contrário retorna não encontrado</returns>
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            Business.DTOs.CustomerDTO? result = Business.Customer.SearchById(id);

            if (result == null)
                return (NotFound());

            return (Ok(result));
        }

        /// <summary>
        /// Método para atualizar o cliente com o id desejado
        /// </summary>
        /// <param name="id">Id do cliente desejado</param>
        /// <param name="customer">Objeto contendo informações do cliente</param>
        /// <returns>Retorna status code 200 se executado com sucesso, caso contrário retorna não encontrado</returns>
        [HttpPut("{id}")]
        public ActionResult<string> Put(string id, [FromBody] Business.DTOs.CustomerDTO customer)
        {
            customer.Id = id;

            bool result = Business.Customer.Update(customer);

            if (result)
                return (Ok());
            else
                return (NotFound());
        }

        /// <summary>
        /// Método para excluir um cliente com o id desejado
        /// </summary>
        /// <param name="id">Id do cliente desejado</param>
        /// <returns>Retorna status code 200 se executado com sucesso, caso contrário retorna não encontrado</returns>
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(string id)
        {
            bool result = Business.Customer.Delete(id);

            if (result)
                return (Ok());
            else
                return (NotFound());
        }
    }
}