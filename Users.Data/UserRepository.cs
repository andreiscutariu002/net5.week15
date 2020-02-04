namespace Users.Data
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using BusinessLogic;

    public class CityRepository : ICityRepository
    {
        public List<City> GetAll()
        {
            var cities = new List<City>
            {
                new City(1, "Iasi"),
                new City(2, "Vaslui"),
                new City(3, "Suceava"),
                new City(4, "Bacau"),
                new City(5, "Galati")
            };

            return cities;
        }
    }

    public class UserRepository : IUserRepository
    {
        private readonly SqlConnection connection;

        public UserRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public List<User> GetAll()
        {
            var list = new List<User>();

            var query = "select * from users";
            var command = new SqlCommand
            {
                CommandText = query,
                Connection = this.connection
            };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var userId = (int) reader["id"];
                    var userName = reader["username"] as string;
                    var email = reader["email"] as string;
                    var description = reader["description"] as string;
                    var city = reader["city"] as string;
                    var street = reader["street"] as string;

                    list.Add(new User
                    {
                        Id = userId,
                        Email = email,
                        Description = description,
                        Username = userName,
                        Street = street,
                        City = city
                    });
                }
            }

            return list;
        }
    }
}
