using System.Data.Entity;
using DbModel;

namespace Store.Services
{

    public interface IUserContext
    {
        public List<User>GetAllUser();
        public User? GetUserById(int id);
        public User AddUser(User user);

    }

    public class UserContext : DbContext, IUserContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<User> Users { get; set; }

        public UserContext(IConfiguration configuration) : base(configuration.GetConnectionString("BlockChainStoreDb"))  
        {
            _configuration = configuration;
        }
        public List<User> GetAllUser() {

            using (var db = new UserContext(_configuration))
            {
                return db.Users.ToList();
            }
        }
        public User? GetUserById(int id)
        {
            using (var db = new UserContext(_configuration))
            {
                return db.Users.Where(u=>u.Id == id).FirstOrDefault();
            }
        }
        public User AddUser(User user)
        {
            using (var db = new UserContext(_configuration))
            {
                var e = db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
        }
    }
}
