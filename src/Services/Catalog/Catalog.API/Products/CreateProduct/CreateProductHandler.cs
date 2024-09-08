using BuildingBlocks.CQRS;
using Catalog.API.Models;
using Marten;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{// Here implements Command Query Responsibility Segregation (CQRS) pattern by using MediatR library

    public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
        :ICommand<CreateProductResult>; //ICommand inherites from IRequest of MediaR Library
    public record CreateProductResult(Guid Id);
    internal class CreateProductCommandHandler(IDocumentSession session) 
        : ICommandHandler<CreateProductCommand, CreateProductResult> //ICommandHandler interites from IRequestHandler of MediaR Library
    {// This is in business logic layer
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            // Create Product entity from command object

            var product = new Product
            { 
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price            
            };

            //TODO:
            // Save to database
            session.Store(product);
            await session.SaveChangesAsync(cancellationToken);

            // return CreateProductResult result
            return new CreateProductResult(product.Id);// Return new product id

        }
    }
}
