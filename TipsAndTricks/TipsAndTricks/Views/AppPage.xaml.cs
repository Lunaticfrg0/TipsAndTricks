using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipsAndTricks.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipsAndTricks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppPage : ContentPage
    {
        public AppPage()
        {
            InitializeComponent();
            BindingContext = new AppPageViewModel();
        }
    }
}