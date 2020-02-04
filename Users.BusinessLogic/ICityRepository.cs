namespace Users.BusinessLogic
{
    using System.Collections.Generic;

    public interface ICityRepository
    {
        List<City> GetAll();
    }
}
