using MediatR;
using TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>> {

}