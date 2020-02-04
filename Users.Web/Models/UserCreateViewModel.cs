namespace Users.Web.Models
{
    using BusinessLogic;

    public class UserCreateViewModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public string City { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public Role Role { get; set; }
    }
}
