using System.Linq;
using Core.Models.Database;

namespace Core.Respositories
{
    public class UserRepository
    {
        private readonly DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public UserDatabaseModel GetByEmail(string email)
        {
            return _databaseContext.UserDatabaseModel.SingleOrDefault(x => x.Email == email);
        }

        public void Save(UserDatabaseModel user)
        {
            var userFromDb = _databaseContext.UserDatabaseModel.SingleOrDefault(x => x.Id == user.Id);
            if(userFromDb != null)
            {
                userFromDb = user;
            }
            else
            {
                _databaseContext.UserDatabaseModel.Add(user);
            }
            _databaseContext.SaveChanges();
        }
    }
}