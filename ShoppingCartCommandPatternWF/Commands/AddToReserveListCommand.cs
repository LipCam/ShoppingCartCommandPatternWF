using ShoppingCartCommandPatternWF.Entities;
using ShoppingCartCommandPatternWF.Interfaces;

namespace ShoppingCartCommandPatternWF
{
    public class AddToReserveListCommand : ICommand
    {
        private IReserveList _reserveList;
        private Produto _produto;

        public AddToReserveListCommand(IReserveList reserveList, Produto produto)
        {
            _reserveList = reserveList;
            _produto = produto;
        }

        public void Execute()
        {
            _reserveList.AddItem(_produto);
        }

        public void Undo()
        {
            _reserveList.RemoveItem(_produto);
        }
    }
}
