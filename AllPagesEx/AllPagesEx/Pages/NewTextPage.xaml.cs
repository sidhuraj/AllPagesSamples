using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AllPagesEx.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTextPage : ContentPage
    {
        public NewTextPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

          



        }
    }
}