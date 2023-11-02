namespace ShoppingCartCommandPatternWF.Interfaces
{
    public interface ICommandManager
    {
        public void Invoke(ICommand command);
        public void Undo();
    }
}
