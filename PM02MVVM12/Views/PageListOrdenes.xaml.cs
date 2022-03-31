using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02MVVM12.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListOrdenes : ContentPage
    {
        public PageListOrdenes()
        {
            InitializeComponent();
        
            BindingContext = new ViewModels.ListOrdenesViewModel(Navigation);
           
        }
    }
}