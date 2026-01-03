using EX12Command;
using EX12Command.Presents;

SantaHelper santaHelper = new SantaHelper();
santaHelper.SetCommand(CommandOption.AddPresent);
santaHelper.SetPresent(new Toy("Action Figure", "Superhero action figure"));
santaHelper.ExecuteCommand();

santaHelper.SetCommand(CommandOption.AddPresent);
santaHelper.SetPresent(new Toy("Zigzak McQueen", "A car"));
santaHelper.ExecuteCommand();

santaHelper.SetCommand(CommandOption.AddPresent);
santaHelper.SetPresent(new Toy("C# Programming", "An in-depth guide to C# programming"));
santaHelper.ExecuteCommand();

Console.WriteLine("Print after adding 3 presents");
santaHelper.ShowCurrentPresents();

// Remove the Zigzak McQueen toy
santaHelper.SetCommand(CommandOption.RemovePresent);
santaHelper.SetPresent(new Toy("Zigzak McQueen", "A car"));
santaHelper.ExecuteCommand();

Console.WriteLine("Print after removing 1 present");
santaHelper.ShowCurrentPresents();

santaHelper.SetCommand(CommandOption.AddPresent);
santaHelper.SetPresent(new Toy("Zigzak McQueen", "A car"));
santaHelper.ExecuteCommand();

santaHelper.SetCommand(CommandOption.AddPresent);
santaHelper.SetPresent(new Twig("Magic Twig", "Pine Twig"));
santaHelper.ExecuteCommand();

Console.WriteLine("Print after adding 1 toy and 1 twig");
santaHelper.ShowCurrentPresents();
