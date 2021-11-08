namespace Domain.Entities;
public class Product : BaseEntity
{
    public Product(string name, string? barcode, string? description, decimal rate)
    {
        Name = name;
        Barcode = barcode;
        Description = description;
        Rate = rate;
    }

    public string Name { get; set; }
    public string? Barcode { get; set; }
    public string? Description { get; set; }
    public decimal Rate { get; set; }
}
