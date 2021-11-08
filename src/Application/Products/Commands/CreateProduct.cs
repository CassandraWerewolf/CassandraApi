namespace Application.Features.ProductFeatures.Commands;

public class CreateProduct : IRequest<Product>
{
    public string Name { get; set; }
    public string Barcode { get; set; }
    public string Description { get; set; }
    public decimal Rate { get; set; }
    public class CreateProductCommandHandler : IRequestHandler<CreateProduct, Product>
    {
        private readonly IApplicationDbContext _context;
        public CreateProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(CreateProduct command, CancellationToken cancellationToken)
        {            
            var product = new Product(command.Name, command.Barcode, command.Description, command.Rate);
            
            _context.Products.Add(product);
            await _context.SaveChangesAsync(cancellationToken);
            return product;
        }
    }
}