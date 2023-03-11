namespace Homework.Models;

public class User
{
    private string _password;

    public string Username { get; set; }
    public byte Age { get; set; }
    public string Password
    {
        get => _password;
        set
        {
            if (CheckPassword(value))
                _password = value;
        }
    }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    private bool CheckPassword(string password)
    {
        if (!string.IsNullOrWhiteSpace(password) && password.Length >= 8)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i])) //Pas123sword
                    hasUpper = true;
                else if (char.IsLower(password[i]))
                    hasLower = true;
                else if (char.IsDigit(password[i]))
                    hasDigit = true;

                if (hasUpper && hasLower && hasDigit)
                    return true;
            }
        }

        return false;
    }
}