using System.ComponentModel.Design;

namespace ConsoleApp0.Models
{
    public class Users
    {
        private static Users instance;

        public static Users GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Users();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public List<User> UserList { get; set; }

        private Users() { }

        public User FindByUserId(string userId)
        {
            User? find = UserList.Find(x => x.UserId == userId);
            return find;
        }

        public User Copy(User user)
        {
            if (user != null)
            {
                var newUser = new User();
                newUser.UserId = user.UserId;
                newUser.UserPassword = user.UserPassword;
                newUser.UserPhoneNumber = user.UserPhoneNumber;
                newUser.UserEmail = user.UserEmail;
                newUser.UserBirthDate = user.UserBirthDate;
                newUser.ElectronicDevices = user.ElectronicDevices;
                newUser.RegisterTime = user.RegisterTime;
                return newUser;
            }
            else
            {
                return null;
            }
        }

    }
}
