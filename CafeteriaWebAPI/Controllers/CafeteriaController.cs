using Cafeteria.Contracts.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CafeteriaWebAPI.Controllers
{
    [ApiController]
    
    public class CafeteriaCotroller : ControllerBase
    {
        [HttpPost("/cardapio")]
        public IActionResult CreateCardapio(CreateCardapioRequest request)
        {
            return Ok(request);
        }

        [HttpGet("/cardapio/{id:guid}")]
        public IActionResult GetCardapio(Guid id)
        {
            return Ok(id);
        }

        [HttpPut("/cardapio/{id:guid}")]
        public IActionResult UpsertCardapio(Guid id, UpsertCardapioRequest request)
        {
            return Ok(request);
        }

        [HttpDelete("/cardapio/{id:guid}")]
        public IActionResult DeleteCardapio(Guid id)
        {
            return Ok(id);
        }
    }
}