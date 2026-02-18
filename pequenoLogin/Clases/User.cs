class User {
    public string Username {get; private set;}
    public string Password {get; private set;}

    public User(string username, string password) { //Constructor
        Username = username;
        Password = password;
    }
}