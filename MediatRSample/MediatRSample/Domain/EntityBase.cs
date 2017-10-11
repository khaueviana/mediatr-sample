using FluentValidator;
using System;

namespace MediatRSample.Domain
{
    public class EntityBase : Notifiable
    {
        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
