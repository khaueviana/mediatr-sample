using MediatR;

namespace MediatRSample.Domain
{
    public class ProductHandler : IRequestHandler<Product, Response>
    {
        public Response Handle(Product message)
        {
            return new Response(new { message = "Produto inserido com sucessio." });
        }
    }
}