using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_pattern.Classes
{
    public class AddMangerCommand : ICommand
    {
        private readonly CustomerService customerService;
        public AddMangerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddManager();
        }
    }
}
