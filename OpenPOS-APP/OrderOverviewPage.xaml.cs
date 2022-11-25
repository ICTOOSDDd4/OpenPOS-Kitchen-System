using OpenPOS_APP.Models;
using OpenPOS_APP.Services.Models;

namespace OpenPOS_APP;

public partial class OrderOverviewpage : ContentPage
{
	public List<Order> Orders { get; set; }
	private HorizontalStackLayout HorizontalLayout;
	public OrderOverviewpage()
	{
		Orders = OrderService.GetAllOpenOrders();
		InitializeComponent();

		for (int i = 0; i < Orders.Count; i++)
		{
			AddProductToLayout(Orders[i]);
		}
		
	}

	private void OrderCanceled(object sender, EventArgs e)
	{
		OrderView view = (OrderView)sender;
		Order order = view.order;
		order.Status = false;
		OrderService.Update(order);
	}

	private void OrderDone(object sender, EventArgs e)
	{
      OrderView view = (OrderView)sender;
      Order order = view.order;
      order.Status = true;
      OrderService.Update(order);
   }
	public void AddProductToLayout(Order order)
	{
      if (HorizontalLayout == null || HorizontalLayout.Children.Count % 8 == 0)
      {
			AddHorizontalLayout();
      }
      
	}

	private void AddHorizontalLayout()
	{
   }
	
	
	
}