using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12Command
{
    public class PresentsOrder
    {
        private List<AbstractPresent> _presents;
        public PresentsOrder()
        {
            _presents = new List<AbstractPresent>();
        }
        public void ExecuteCommand(ChristmasCommand command, AbstractPresent item)
        {
            command.Execute(_presents, item);
        }
        public void ShowCurrentPresents()
        {
            foreach (var item in _presents)
            {
                item.DisplayInfo();
            }
            Console.WriteLine("-----------------------");
        }
    }
}
