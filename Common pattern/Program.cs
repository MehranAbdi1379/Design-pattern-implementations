using Command_pattern.Classes;
using Common_pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var customerService = new CustomerService();
        var addCustomerCommand = new AddCustomerCommand(customerService);
        var addMangerCommand = new AddMangerCommand(customerService);
        var addNewCommand = new AddNewCommand(customerService);

        var commands = new List<ICommand>();
        commands.Add(addCustomerCommand);
        commands.Add(addMangerCommand);
        commands.Add(addNewCommand);

        var compositeCommand = new CompositeCommand(commands);

        var button = new Button(compositeCommand);

        button.Click();

    }
}