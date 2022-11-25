using OpenPOS_APP.Models;
using OpenPOS_APP.Services.Models;

namespace OpenPOS_APP;

public partial class OrderOverviewpage : ContentPage
{
	public List<Product> Products { get; set; }
	public List<Product> SelectedProducts { get; set; }
	private HorizontalStackLayout HorizontalLayout;
	public OrderOverviewpage()
	{
		Order getOrder = OrderService.FindByID(59);
		Products = ProductService.GetAll();
		InitializeComponent();
		SelectedProducts = new List<Product>();

		for (int i = 0; i < Products.Count; i++)
		{
			AddProductToLayout(Products[i]);
		}
		
	}

	public void AddProductToLayout(Product product)
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