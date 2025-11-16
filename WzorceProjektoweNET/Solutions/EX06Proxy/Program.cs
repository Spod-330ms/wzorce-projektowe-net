using EX06Proxy;

FileAccessProxy proxy = new FileAccessProxy();


while(true)
{
    Console.WriteLine("Enter username:");
    string username = Console.ReadLine();
    Console.WriteLine("Enter password:");
    string password = Console.ReadLine();
    if (proxy.Authenticate(username, password))
    {
        Console.WriteLine("Enter the filename to read:");
        string fileName = Console.ReadLine();
        proxy.ReadFile(fileName);
        break;
    }
    else
    {
        Console.WriteLine("Invalid credentials. Please try again.");
    }
}

Console.WriteLine("Test of unatuhenticated access");
proxy.Authenticate("fake", "fake");
proxy.ReadFile("secret.txt"); //Will fail due to lack of authentication