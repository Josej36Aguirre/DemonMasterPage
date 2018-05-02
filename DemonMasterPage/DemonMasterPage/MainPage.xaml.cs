using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemonMasterPage
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
           // btnMaestro.Clicked += BtnMaestro_Clicked;

        }

        //private void BtnMaestro_Clicked(object sender, EventArgs e)
        //{
        //    ((NavigationPage)this.Parent).Navigation.PushAsync(new Maestro());
        //}
    }
}
