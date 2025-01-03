using CqrsExample.Api.Commands.CqrsExample.Application.Commands;
using MediatR;

namespace CqrsExample.Api.Handlers
{

    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        public Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            // Simulate saving to database
            var customerId = Guid.NewGuid();
            return Task.FromResult(customerId);
        }
    }

}
