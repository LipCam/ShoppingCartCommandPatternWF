using ShoppingCartCommandPatternWF.Interfaces;

namespace ShoppingCartCommandPatternWF.Commands
{
    class CommandManager : ICommandManager
    {
        Stack<ICommand> lstCommands = new Stack<ICommand>();

        public void Invoke(ICommand command)
        {
            lstCommands.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (lstCommands.Count > 0)
            {
                ICommand command = lstCommands.Pop();
                command.Undo();
            }
        }
    }
}
