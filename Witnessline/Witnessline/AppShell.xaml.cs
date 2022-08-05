using System;
using System.Collections.Generic;
using Witnessline.ViewModels;
using Witnessline.Views;
using Xamarin.Forms;

namespace Witnessline
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
