using AllPagesEx.Model;
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
    public partial class WelcomePage : MasterDetailPage
    {
        public WelcomePage()
        {
            InitializeComponent();

            bindstateNames();
            
            NavigationPage.SetHasNavigationBar(this, false); //this command is goes to"To hide the Navigation bar in present page:(ex:welcome page)//

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(TelanganaPage)));
        }

        private void bindstateNames()
        {
            List<State> objStatesList = new List<State>();
            objStatesList.Add(new State { StateIcon = "icon.png", StateName = "Telangana",TargetType = typeof(TelanganaPage) });
            objStatesList.Add(new State { StateIcon = "icon.png", StateName = "Andrapradesh", TargetType = typeof(AndrapradeshPage) });
            objStatesList.Add(new State { StateIcon = "icon.png", StateName = "Karnataka", TargetType = typeof(TelanganaPage) });
            objStatesList.Add(new State { StateIcon = "icon.png", StateName = "Tamilnadu", TargetType = typeof(AndrapradeshPage) });
            objStatesList.Add(new State { StateIcon = "icon.png", StateName = "Kerala", TargetType = typeof(TelanganaPage) });

            lbxStatesList.ItemsSource = objStatesList;

            lbxStatesList.ItemSelected += LbxStatesList_ItemSelected;

        }

        private void LbxStatesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as State;

            //if (item != null)
            //{
            //    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            //    IsPresented = false;
            //}
        }
    }
}