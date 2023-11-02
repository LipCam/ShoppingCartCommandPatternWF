using ShoppingCartCommandPatternWF.Entities;

namespace ShoppingCartCommandPatternWF.Interfaces
{
    public interface IShoppingCart
    {
        void AddItem(Produto produto);
        void RemoveItem(Produto produto);
        int GetQtd();
        decimal GetTotal();
    }
}
