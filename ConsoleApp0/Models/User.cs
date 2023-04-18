namespace ConsoleApp0.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserBirthDate { get; set; }
        public List<object> ElectronicDevices { get; set; } = new List<object>();
        public DateTime RegisterTime { get; set; }

        public User()
        {
            RegisterTime = DateTime.Now;
        }
    }

    
}
