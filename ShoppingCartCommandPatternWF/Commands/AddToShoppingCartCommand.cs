using ShoppingCartCommandPatternWF.Entities;
using ShoppingCartCommandPatternWF.Interfaces;

namespace ShoppingCartCommandPatternWF
{
    public class AddToShoppingCartCommand : ICommand
    {
        private IShoppingCart _shoppingCart;
        private Produto _produto;

        public AddToShoppingCartCommand(IShoppingCart shoppingCart, Produto produto)
        {
            _shoppingCart = shoppingCart;
            _produto = produto;
        }

        public void Execute()
        {
            _shoppingCart.AddItem(_produto);
        }

        public void Undo()
        {
            _shoppingCart.RemoveItem(_produto);
        }
    }
}
