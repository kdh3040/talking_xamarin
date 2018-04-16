using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talkking2.DA;
using Talkking2.Model;
using Xamarin.Forms;

namespace Talkking2
{
	public partial class MainPage : ContentPage
	{
        ObservableCollection<UserData> obs = new ObservableCollection<UserData>();

        public MainPage()
		{
			InitializeComponent();
            //_lst.BindingContext = obs;
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var db = new DaFireBase();

            var dblit = await db.getMyData();

            foreach (var item in dblit)
            {
                obs.Add(item);
            }







        }
    }
}
