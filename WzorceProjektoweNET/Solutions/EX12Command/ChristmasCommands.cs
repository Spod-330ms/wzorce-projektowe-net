using EX12Command.Presents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command
{
    public enum CommandOption
    {
        AddPresent = 1,
        RemovePresent = 2
    }

    public abstract class ChristmasCommand
    {
        public abstract void Execute(List<AbstractPresent> presents, AbstractPresent item);
    }

    public class AddPresentCommand : ChristmasCommand
    {
        public override void Execute(List<AbstractPresent> presents, AbstractPresent item)
        {
            presents.Add(item);
            Console.WriteLine($"Added present: {item.Name}");
        }
    }
    public class RemovePresentCommand : ChristmasCommand
    {
        public override void Execute(List<AbstractPresent> presents, AbstractPresent item)
        {
            presents.RemoveAll(p => p.Name == item.Name);
            Console.WriteLine($"Removed present: {item.Name}");
        }
    }
}
