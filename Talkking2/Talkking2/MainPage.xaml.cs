using Firebase.Database;
using Firebase.Database.Query;
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
       private DataMng mDataMng = DataMng.getInstance();
        FirebaseClient client;
        DaFireBase DAF ;
        public MainPage()
		{
			InitializeComponent();
            client = new FirebaseClient("https://test-d27a4.firebaseio.com/");
            DAF = new DaFireBase();


            _lst.BindingContext = mDataMng;
            InitMyData();
        //    InitUserData();
        }

        async void InitMyData()
        {
            await DAF.GetMyData();
        }
        async void InitUserData()
        {
         //   await DAF.GetUserData_Heart();
            //await DAF.GetUserData_Fan();
            //await DAF.GetUserData_Near();
            //await DAF.GetUserData_New();
            
        }
    }
}
