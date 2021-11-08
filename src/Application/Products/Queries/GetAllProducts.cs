namespace Application.Features.ProductFeatures.Queries;

public class GetAllProducts : IRequest<IEnumerable<Product>>
{
    public class GetAllProductsHandler : IRequestHandler<GetAllProducts, IEnumerable<Product>>
    {
        private readonly IApplicationDbContext _context;
        public GetAllProductsHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> Handle(GetAllProducts query, CancellationToken cancellationToken)
        {
            var productList = await _context.Products.ToListAsync(cancellationToken);
            if (productList == null)
            {
                return new List<Product>();
            }
            return productList.AsReadOnly();
        }
    }
}
