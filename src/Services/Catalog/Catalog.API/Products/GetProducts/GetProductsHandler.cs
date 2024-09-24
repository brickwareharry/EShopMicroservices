namespace Catalog.API.Products.GetProducts
{// Here implements Command Query Responsibility Segregation (CQRS) pattern by using MediatR library
    public record GetProductsQuery() : IQuery<GetProductsResult>;//IQuery inherites from IRequest of MediaR Library
    public record GetProductsResult(IEnumerable<Product> Products);

    internal class GetProductsQueryHandler(IDocumentSession session, ILogger<GetProductsQueryHandler> logger)
        // IDocumentSection is from dependency injection container of Marten Library for database operations
        // ILogger is from Microsoft.Extensions.Logging. Since .NET 6, this logging library is included in WebApplication.
        // The logger object is injected by dependency injection container automatically so builder.Services.AddLogging() is not needed.
        : IQueryHandler<GetProductsQuery, GetProductsResult> //ICommandHandler interites from IRequestHandler of MediaR Library
    {
        public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
        {

            logger.LogInformation("GetProductsQueryHandler.Handle called with {@Query}", query);
            var products = await session.Query<Product>().ToListAsync(cancellationToken);
            return new GetProductsResult(products);
        }
    }

}
