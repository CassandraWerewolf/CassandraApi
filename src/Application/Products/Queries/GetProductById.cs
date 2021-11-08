namespace Application.Features.ProductFeatures.Queries;

public class GetProductById : IRequest<Product>
{
    public int Id { get; set; }
    public class GetProductByIdHandler : IRequestHandler<GetProductById, Product>
    {
        private readonly IApplicationDbContext _context;
        public GetProductByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(GetProductById query, CancellationToken cancellationToken)
        {
            await Task.Delay(30_000, cancellationToken);
            var product = await _context.Products.Where(a => a.Id == query.Id).FirstOrDefaultAsync(cancellationToken);
            if (product == null) return null!;
            return product;
        }
    }
}
