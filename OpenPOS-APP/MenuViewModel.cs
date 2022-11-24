using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPOS_APP
{
    class MenuViewModel : INotifyPropertyChanged{
        
        public MenuViewModel() {
            Product.Add("Spaghetti");
            Product.Add("TomatenSoep");
            Product.Add("Boerenkool");
            Product.Add("Kipnuggets");
            Product.Add("Hamburger");
        }
        public ObservableCollection<String> Product { get; set; } = new ObservableCollection<String>();
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
