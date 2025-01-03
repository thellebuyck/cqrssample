using CqrsExample.Application.Queries;
using CqrsExample.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CqrsExample.Application.Handlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, Customer>
    {
        public Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            // Simulate retrieving data
            return Task.FromResult(new Customer { Id = request.Id, Name = "John Doe", Email = "john@example.com" });
        }
    }
}
