using MediatR;

namespace CqrsExample.Api.Commands
{
    namespace CqrsExample.Application.Commands
    {
        public class CreateCustomerCommand : IRequest<Guid>
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }

}
