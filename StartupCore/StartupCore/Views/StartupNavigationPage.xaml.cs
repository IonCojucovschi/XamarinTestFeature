using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StartupCore.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartupNavigationPage : NavigationPage
    {
        public StartupNavigationPage()
        {
            InitializeComponent();
        }

        public StartupNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }
    }
}
