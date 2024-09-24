
namespace Catalog.API.Products.GetProducts
{
    //public record GetProductsRequest();
    public record GetProductsResponse(IEnumerable<Product> Products);

    public class GetProductsEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/products", async (ISender sender) =>
            {
                //Send functoin of MediatR sends the query to the Handle function of GetProductsQueryHandler
                var result = await sender.Send(new GetProductsQuery());

                //using Adapt function of Mapster library maps the result of GetProductsResult from Handle function back to GetProductsResponse above
                var response = result.Adapt<GetProductsResponse>();
                return Results.Ok(response);
            })
            .WithName("GetProducts")
            .Produces<GetProductsResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Get Products")
            .WithDescription("Get Products");
        }
    }

}
