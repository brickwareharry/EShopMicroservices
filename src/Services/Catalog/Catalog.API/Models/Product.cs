namespace Catalog.API.Models
{
    public class Product
    {// This is in the domain layer

        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
#pragma warning disable IDE0028
        public List<string> Category { get; set; } = new();
#pragma warning restore IDE0028
        public string Description { get; set; } = default!;
        public string ImageFile { get; set; } = default!;
        public decimal Price { get; set; }

    }
}
