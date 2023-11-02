using ShoppingCartCommandPatternWF.Entities;
using ShoppingCartCommandPatternWF.Interfaces;

namespace ShoppingCartCommandPatternWF
{
    public partial class Form1 : Form
    {
        private readonly ICommandManager _commandManager;
        private readonly IShoppingCart _shoppingCart;
        private readonly IReserveList _reserveList;        

        public Form1(ICommandManager commandManager, IShoppingCart shoppingCart, IReserveList reserveList)
        {
            InitializeComponent();

            _commandManager = commandManager;
            _shoppingCart = shoppingCart;
            _reserveList = reserveList;            

            GetDetails();
        }

        private void GetDetails()
        {
            lblQtdCart.Text = _shoppingCart.GetQtd().ToString();
            lblTotalCart.Text = _shoppingCart.GetTotal().ToString("c");
            lblQtdReservList.Text = _reserveList.GetQtd().ToString();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            _commandManager.Invoke(new AddToShoppingCartCommand(_shoppingCart, new Produto() { Descricao = "Barraca de Camping Grande", Valor = 20 }));
            GetDetails();
        }

        private void btnAddReservList_Click(object sender, EventArgs e)
        {
            _commandManager.Invoke(new AddToReserveListCommand(_reserveList, new Produto() { Descricao = "Barraca de Camping Grande", Valor = 20 }));
            GetDetails();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _commandManager.Undo();
            GetDetails();
        }
    }
}