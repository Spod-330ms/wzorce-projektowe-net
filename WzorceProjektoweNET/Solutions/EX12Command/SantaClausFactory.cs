using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command
{
    public static class SantaClausFactory
    {
        public static ChristmasCommand GetCommand(CommandOption commandOption)
        {
            switch (commandOption)
            {
                case CommandOption.AddPresent:
                    return new AddPresentCommand();
                case CommandOption.RemovePresent:
                    return new RemovePresentCommand();
                default:
                    throw new ArgumentException("Invalid command option");
            }
        }
    }
}
