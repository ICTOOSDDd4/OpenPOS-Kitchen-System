using OpenPOS_APP.Models;
using OpenPOS_APP.Services.Models;
using System.Runtime.CompilerServices;

namespace OpenPOS_APP;

public partial class OrderOverviewpage : ContentPage
{
	public List<Order> Orders { get; set; }
	private HorizontalStackLayout HorizontalLayout;

   private bool _isInitialized;
   private double _width;

   public OrderOverviewpage()
	{
		InitializeComponent();
      Orders = OrderService.GetAllOpenOrders();

   }

   protected override void OnSizeAllocated(double width, double height)
   {
      base.OnSizeAllocated(width, height);
      if (!_isInitialized)
      {
         _isInitialized = true;
         SetWindowScaling(width, height);
      }

   }

   private void SetWindowScaling(double width, double height)
   {
      ScrView.HeightRequest = height - 300;
      _width = width;
      AddAllOrders();

   }

   private void OrderCanceled(object sender, EventArgs e)
	{
		OrderView view = (OrderView)sender;
		Order order = view.order;
		order.Status = null;
		OrderService.Update(order);
      DeleteView(view);
   }

   private void OrderDone(object sender, EventArgs e)
	{
      OrderView view = (OrderView)sender;
      Order order = view.order;
      order.Status = true;
      OrderService.Update(order);
      DeleteView(view);
   }

   private void DeleteView(OrderView view)
   {
      view.layout.Children.Remove(view);
   }

   private async void ClickedRefresh(object sender, EventArgs e)
   {
      await Shell.Current.GoToAsync(nameof(OrderOverviewpage));
   }


   private void AddAllOrders()
   {
      for (int i = 0; i < Orders.Count; i++)
      {
         AddOrderToLayout(Orders[i]);
      }
   }

	public void AddOrderToLayout(Order order)
	{
      int moduloNumber = ((int)_width / 300);
      if (HorizontalLayout == null || HorizontalLayout.Children.Count % moduloNumber == 0)
      {
			AddHorizontalLayout();
      }

		OrderView orderview = new OrderView();
		orderview.AddBinds(order, HorizontalLayout);
      orderview.OrderDone += OrderDone;
      orderview.OrderCanceled += OrderCanceled;
      HorizontalLayout.Add(orderview);      
	}

	private void AddHorizontalLayout()
	{
      HorizontalStackLayout hLayout = new HorizontalStackLayout();
      hLayout.Spacing = 20;
      hLayout.Margin = new Thickness(10);
      MainVerticalLayout.Add(hLayout);
      HorizontalLayout = hLayout;
   }
	
	
	
}