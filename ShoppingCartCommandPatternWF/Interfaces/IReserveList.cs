using ShoppingCartCommandPatternWF.Entities;

namespace ShoppingCartCommandPatternWF.Interfaces
{
    public interface IReserveList
    {
        void AddItem(Produto produto);
        void RemoveItem(Produto produto);
        int GetQtd();
    }
}
