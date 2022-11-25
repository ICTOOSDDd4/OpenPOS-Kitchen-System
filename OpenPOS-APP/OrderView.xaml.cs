using OpenPOS_APP.Controllers;
using OpenPOS_APP.Models;
using OpenPOS_APP.Services.Models;

namespace OpenPOS_APP;

public partial class OrderView : ContentPage
{
   private Order _order;
	public OrderView()
	{
		InitializeComponent();
      MainVerticalLayout.Shadow = new Shadow
      {
         Offset = new Point(5, 5),
         Brush = Brush.Black,
         Opacity = 0.12f,
      };
   }

   private void OnClickedDone(object sender, EventArgs e)
   {

   }

   private void OnClickedCancel(object sender, EventArgs e)
   {

   }

   public void BindOrder(Order order)
   {
      _order = order;
      OrderNUmber.Text = $"Order: {_order.Id}";
      Bill bill = BillService.FindByID(_order.Bill_id);
      //TableNumber.Text = $"Table: {_order.}
   }

   private void AddOrderLinesToLayout()
   {
      foreach(OrderLine line in _order.Lines) 
      {
         Product product = ProductService.FindByID(line.Product_id);
         Label label = new Label();
         label.Text = product.Name;
         OrderLinesLayout.Add(label);
      }
   }

}