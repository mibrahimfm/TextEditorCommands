using TextEditorCommands.Command;

namespace TextEditorCommands.Invoker
{
    internal class CommandInvoker
    {
        private Stack<ICommand> commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No command to undo.");
            }
        }
    }
}
