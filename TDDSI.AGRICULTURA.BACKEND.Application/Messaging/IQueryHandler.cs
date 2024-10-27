using MediatR;
using TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Messaging;
public interface IQueryHandler<TQuery, TResponse>
: IRequestHandler<TQuery, Result<TResponse>>
where TQuery : IQuery<TResponse> {

}
