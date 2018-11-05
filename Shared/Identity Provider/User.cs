namespace Shared.Identity_Provider
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Role role { get; set; }
    }
}