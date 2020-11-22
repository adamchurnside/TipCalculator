using System.ComponentModel;
using Xamarin.Forms;
using TipCalculator.ViewModels;

namespace TipCalculator.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}