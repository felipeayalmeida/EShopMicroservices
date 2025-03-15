using MediatR;

namespace BuildingBlocks.CQRS;

// Generic for Commands without Response
public interface ICommand : IRequest<Unit>
{
}

// Generic for Commands with Response
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}

