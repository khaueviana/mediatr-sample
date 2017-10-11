using Microsoft.AspNetCore.Mvc;
using MediatR;
using MediatRSample.Domain;

namespace MediatRSample.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IMediator _mediatr;

        public ProductController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product message)
        {
            var response = _mediatr.Send(message);
            return Ok(response);
        }
    }
}