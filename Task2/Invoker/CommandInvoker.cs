using System.Windows.Input;
using Task2.Commands;

namespace Task2.Invoker
{
    internal class CommandInvoker
    {
        private IVideoCommand _command;

        public void SetCommand(IVideoCommand command) 
        {
            _command = command;
        }

        public void ExecuteCommand() 
        {
            _command.Execute();
        }
    }
}
