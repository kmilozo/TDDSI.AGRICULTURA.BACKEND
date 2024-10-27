using MediatR;

namespace TDDSI.AGRICULTURA.BACKEND.Application.Messaging;
public interface INotifyHandler<TCommand> : INotificationHandler<TCommand>
where TCommand : INotify {

}
