using MediatR;

namespace USP.Application.Product.Commands;

public record CreateProductCommand(string Name, string Description, decimal Price) : IRequest<string>;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, string>
{
    public async Task<string> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        return "Success";
    }
}