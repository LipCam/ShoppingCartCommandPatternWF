using ShoppingCartCommandPatternWF.Entities;
using ShoppingCartCommandPatternWF.Interfaces;

namespace ShoppingCartCommandPatternWF.Business
{
    public class ReserveList : IReserveList
    {
        private List<Produto> lst = new List<Produto>();

        public void AddItem(Produto produto)
        {
            lst.Add(produto);
        }

        public void RemoveItem(Produto produto)
        {
            if (lst.Contains(produto))
            {
                lst.Remove(produto);
            }
        }

        public int GetQtd()
        {
            return lst.Count;
        }
    }
}
