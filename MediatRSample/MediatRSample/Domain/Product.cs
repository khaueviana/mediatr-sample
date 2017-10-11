using FluentValidator;
using MediatR;

namespace MediatRSample.Domain
{
    public class Product : EntityBase, IRequest<Response>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;

            new ValidationContract<Product>(this)
                .IsRequired(x => x.Name, "Nome do produto obrigatório")
                .IsGreaterOrEqualsThan(x => x.Price, 0, "Valor deve ser maior que zero.");
        }
    }
}