using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemonMasterPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Maestro : MasterDetailPage
	{
		public Maestro ()
		{
			InitializeComponent ();
           // btnMaestr2.Clicked += BtnMaestr2_Clicked;

        }

        //private void BtnMaestr2_Clicked(object sender, EventArgs e)
        //{
        //    ((NavigationPage)this.Parent).Navigation.PushAsync(new Detalle());
        //}
    }
}