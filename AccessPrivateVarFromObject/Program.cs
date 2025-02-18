// See https://aka.ms/new-console-template for more information

var user = new User("Fura");

User.SayHello(user);
public class User {
    public static void SayHello(User user) {
        Console.WriteLine($"Hello my name is {user._name}");
    }

    private string _name;
    public User(string name) {
        _name = name;
    }
}