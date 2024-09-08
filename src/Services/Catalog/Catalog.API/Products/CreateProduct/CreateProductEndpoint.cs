using Carter;
using Mapster;
using MediatR;


namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductRequest(string Name, List<string> Category, string Description, string ImageFile, decimal Price);
    
    public record CreateProductResponse(Guid Id);
    public class CreateProductEndpoint : ICarterModule
    {// this is in presentation API layer
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/products", async (CreateProductRequest request, ISender sender) =>
            {
                //using Adapt function of Mapster library maps the incoming request (i.e. object of CreateProductRequest above) to CreateProductCommand (i.e. request object of MediatR in CreateProductHandler.cs)
                var command = request.Adapt<CreateProductCommand>();

                //Send functoin of MediatR sends the command to the Handle function of CreateProductCommandHandler
                var result = await sender.Send(command);

                //using Adapt function of Mapster library maps the result of CreateProductResponse from Handle function back to CreateProductResponse above
                var response = result.Adapt<CreateProductResponse>();

                return Results.Created($"/products/{response.Id}", response);
            })
                // below is from Carter Library
                .WithName("CreateProduct")
                .Produces<CreateProductResponse>(StatusCodes.Status201Created)
                .ProducesProblem(StatusCodes.Status400BadRequest)
                .WithSummary("Create Product")
                .WithDescription("Create Product");
                
            
        }
    }
}
