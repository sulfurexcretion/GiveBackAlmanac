using GiveBackAlmanac.ViewModels;
using GiveBackAlmanac.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GiveBackAlmanac
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
