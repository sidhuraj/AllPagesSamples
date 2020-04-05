using AllPagesEx.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AllPagesEx
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();


            //Children.Add(new VehiclesPage());
            //Children.Add(new PeoplesListPage());
            //Children.Add(new BooksListPage());
            //btn.Clicked += Btn_Clicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("#2196F3");
        }


        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewTextPage());
        }

        
        

        

      
        

         
    }
} 
