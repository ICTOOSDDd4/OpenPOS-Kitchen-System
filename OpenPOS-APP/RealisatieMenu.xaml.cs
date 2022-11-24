using Microsoft.UI.Xaml.Controls;
using OpenPOS_APP.Models;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace OpenPOS_APP;

public partial class RealisatieMenu : ContentPage {
    public RealisatieMenu(){
        InitializeComponent();
        List<Product> ProductList = new List<Product>();

        ProductList.Add(new Product(1, "Spaghetti", 2.25, "Spaghetti met tomatensaus", "spaghetti.png"));
        ProductList.Add(new Product(2, "Tomatensoep", 3.55, "Soep met tomaat", "Tomatensoep.png"));
        ProductList.Add(new Product(3, "Stamppot Boerenkool", 4.25, "Aardappels met boerenkool", "Boerenkool.png"));
        ProductList.Add(new Product(4, "Kipnuggets", 1.55, "Nuggets met kip", "kipnuggets.png"));
        ProductList.Add(new Product(5, "Hamburger", 1.75, "Burger met ham", "hamburger.png"));
        RealisatieMenuItems.ItemsSource = ProductList;
    }

}