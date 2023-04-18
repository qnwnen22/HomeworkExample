namespace ConsoleApp0.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string UserPassword { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserBirthDate { get; set; }
        public List<Electronic> ElectronicDevices { get; set; } = new List<Electronic>();
        public DateTime RegisterTime { get; set; }

        public User()
        {
            RegisterTime = DateTime.Now;
        }
    }

    
}
