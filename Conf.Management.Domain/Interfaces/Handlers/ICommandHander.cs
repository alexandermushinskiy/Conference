using Conf.Management.Domain.Interfaces.Commands;

namespace Conf.Management.Domain.Interfaces.Handlers
{
    public interface ICommandHandler
    {
    }

    public interface ICommandHandler<TCommand> : ICommandHandler
        where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
