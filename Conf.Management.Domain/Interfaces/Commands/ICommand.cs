namespace Conf.Management.Domain.Interfaces.Commands
{
    public interface ICommand
    {
    }

    public interface ICommand<out TCommandData> : ICommand
    {
        TCommandData Data { get; }
    }
}
