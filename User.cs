using System.Collections.Generic;

namespace AsyncSolution
{
    public class User
    {
        public string Name { get; set; }
        
        public User(string name)
        {
            Name = name;
        }

        public static List<User> CreateUsers(int collectionSize = 1500)
        {
            List<User> users = new List<User>();
            for (int i = 0; i < collectionSize; i++)
            {
                users.Add(new User($"User {i}"));
            }

            return users;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}