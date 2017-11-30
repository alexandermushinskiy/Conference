namespace Conf.Management.Domain.Interfaces.Providers
{
    public interface IAccessCodeProvider
    {
        string Generate(int length = 5);
    }
}