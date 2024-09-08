using MediatR;

namespace BuildingBlocks.CQRS
{
    //ICommand request does not return a response
    public interface ICommand : ICommand<Unit> 
    { 
    }

    //ICommand request returns a response
    public interface ICommand<out TResponse>: IRequest<TResponse>
    {

    }
}
