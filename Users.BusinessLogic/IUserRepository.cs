namespace Users.BusinessLogic
{
    using System.Collections.Generic;

    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
