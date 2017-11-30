namespace Conf.Management.Domain.Entities
{
    public class ConferenceOrganizer
    {
        public string Name { get; }
        public string Email { get; }

        public ConferenceOrganizer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}