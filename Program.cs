string username;
do
{
    Console.WriteLine("Username:");
    username = Console.ReadLine() ?? string.Empty;
    if (string.IsNullOrEmpty(username) || username.Any(char.IsWhiteSpace) || !username.Any(char.IsLetter))
    {
        Console.WriteLine("Invalid username. Use at least one letter and no spaces.");
    }
} while (string.IsNullOrEmpty(username) || username.Any(char.IsWhiteSpace) || !username.Any(char.IsLetter));

string password;
do
{
    Console.WriteLine("Password:");
    password = Console.ReadLine() ?? string.Empty;
    if (password.Length < 8 || password.Any(char.IsWhiteSpace))
    {
        Console.WriteLine("Invalid password. Use at least 8 characters and no spaces.");
    }
} while (password.Length < 8 || password.Any(char.IsWhiteSpace));

Console.WriteLine($"Login input is valid for {username}.");

 