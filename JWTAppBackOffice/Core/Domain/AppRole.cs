namespace JWTAppBackOffice.Core.Domain
{
    public class AppRole
    {
        public int Id { get; set; }
        public int Definition { get; set; }
        public List<AppUser> AppUsers { get; set; } = new List<AppUser>();
    }
}
