bool status = true;
string name = string.Empty;

while (status)
{
    Console.WriteLine("Username:");
    name = Console.ReadLine();
    for (int i = 0; i < name.Length; i++)
    {
        if(!char.IsWhiteSpace(name[i]) && char.IsLetter(name[i]))
        {
            status = false;
            
        }else
        {
            Console.WriteLine("Invalid input. Please enter a valid username.");
            status = true;
            break;
        }
    }
    }
Console.WriteLine($"Hello, {name}!");

 