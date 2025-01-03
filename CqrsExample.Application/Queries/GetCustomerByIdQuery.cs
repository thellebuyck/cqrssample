
using CqrsExample.Domain.Entities;
using MediatR;

namespace CqrsExample.Application.Queries
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public Guid Id { get; set; }
    }
}
