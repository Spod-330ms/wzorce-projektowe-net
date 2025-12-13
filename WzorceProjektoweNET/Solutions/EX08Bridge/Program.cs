using EX08Bridge;

Console.WriteLine("BRIDGE");
Console.WriteLine("----------");

Console.WriteLine("Select number: \r\n 1. Windows\r\n 2. Linux");
var systemKey = Console.ReadKey();

Console.WriteLine();
Console.WriteLine("Select number for interface accessing the system:\r\n 1. Graphic interface\r\n 2. Console interface");
var interfaceKey = Console.ReadKey();
Console.WriteLine();

ISystem system = null;
if (systemKey.KeyChar == '1')
{
    system = new WindowsSystem();
}
else if(systemKey.KeyChar == '2')
{
    system = new LinuxSystem();
}
else
{
    Console.WriteLine("\r\nInvalid option selected for system.");
    return;
}

AbstractInterface appInterface = null;
if (interfaceKey.KeyChar == '1')
{
    appInterface = new GraphicInterface(system);
}
else if(interfaceKey.KeyChar == '2')
{
    appInterface = new ConsoleInterface(system);
}
else
{
    Console.WriteLine("\r\nInvalid option selected for interface.");
    return;
}

Console.WriteLine("Show menu");
appInterface.displayMenu();