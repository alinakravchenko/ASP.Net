namespace Application.Models
{
    public static class Repository
    {
        private static List<Contact> contacts = new();
        public static IEnumerable<Contact> Contacts => contacts;

        public static string? News { get; internal set; }

        public static void AddResponse(Contact contact)
        {
            Console.WriteLine(contact);
            contacts.Add(contact);
        }

      
    }
}
