using System.ComponentModel;
using Witnessline.ViewModels;
using Xamarin.Forms;

namespace Witnessline.Views
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