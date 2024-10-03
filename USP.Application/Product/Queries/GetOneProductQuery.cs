using MediatR;

namespace USP.Application.Product.Queries;

public record GetOneProductQuery : IRequest<string>;

public class GetOneProductQueryHandler : IRequestHandler<GetOneProductQuery, string>
{
        public async Task<string> Handle(GetOneProductQuery request, CancellationToken cancellationToken) => "Xiaomi 11T Pro"; 
}
