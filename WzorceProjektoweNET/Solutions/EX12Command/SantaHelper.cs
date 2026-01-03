using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command
{
    public class SantaHelper
    {
        private ChristmasCommand _command;
        private AbstractPresent _present;
        private PresentsOrder _presentsOrder;

        public SantaHelper()
        {
            _presentsOrder = new PresentsOrder();
        }
        public void SetCommand(CommandOption option)
        {
            _command = SantaClausFactory.GetCommand(option);
        }
        public void SetPresent(AbstractPresent present)
        {
            _present = present;
        }
        public void ExecuteCommand()
        {
            _presentsOrder.ExecuteCommand(_command, _present);
        }
        public void ShowCurrentPresents()
        {
            _presentsOrder.ShowCurrentPresents();
        }
    }
}
