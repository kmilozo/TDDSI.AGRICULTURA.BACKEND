using MediatR;
using TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Messaging;
public interface ICommand : IRequest<Result>, IBaseCommand {

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand {

}