using MediatR;

namespace BuildingTools.CQRS
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
        where TResponse : notnull
    {

    }
}
