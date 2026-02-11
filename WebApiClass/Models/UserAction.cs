
namespace WebApiClass.Models
{
    public class UserAction
    {
        private readonly static List<User> _list;
        private static int _id;

        static UserAction()
        {
            _list = new List<User>();
            _id = 0;
        }
        public void AddUser( User user)
        { 
            user.Id = ++_id;
            _list.Add(user);
        }
        public void RemoveUser(int id)
        {
            var user = _list.FirstOrDefault(x=>x.Id ==id);
            if (user != null)
            {
                _list.Remove(user);
            }
        }
        public User GetUser(int id) 
        {
            return _list.FirstOrDefault(x => x.Id == id);
        }
        public List<User> GetUsers()
        {
            return _list;
        }
        public void UpdateUser(int id, User input)
        {

           
           var user = _list.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.Name = input.Name;
                user.Email = input.Email;
            }

        }
    }
}
