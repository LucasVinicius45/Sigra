namespace Sigra.Model
{
    public class User
    {
        private string name;
        private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public bool ValidateLogin(string inputName, string inputPassword)
        {
            return name == inputName && password == inputPassword;
        }
    }
}
