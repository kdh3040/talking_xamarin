using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talkking2.Model;

namespace Talkking2.DA
{
    class DaFireBase
    {
        private DataMng mDataMng = DataMng.getInstance();
        FirebaseClient client;

        public DaFireBase()
        {
            client = new FirebaseClient("https://test-d27a4.firebaseio.com");
        }


        public async Task<List<UserData>> getMyIndex()
        {
            var list = (await client
                .Child("UserIdx")
                .OnceAsync<UserData>())
                .Select(item =>
                        new UserData
                        {
                            Age = item.Object.Age,
                            NickName = item.Object.NickName
                        }).ToList();


            return list;

        }

        public async Task GetMyData()
        {
            var list = await client
              .Child("User")
              .Child("13")   
              .OnceAsync<MyData>();
        
            mDataMng.mMyData = (MyData)list;
       
        }

        public async Task GetUserData_Heart()
        {
            var list = (await client
              .Child("User")
              .OrderBy("RecvGold")
              .LimitToFirst(5)
              .OnceAsync<UserData>());

            foreach (var item in list)
            {
                mDataMng.UserData_Heart.Add(item.Key, item.Object);
            }
        }

        public async Task GetUserData_Fan()
        {
            var list = (await client
              .Child("User")
              .OrderBy("FanCount")
              .LimitToFirst(5)
              .OnceAsync<UserData>());

            foreach (var item in list)
            {
                mDataMng.UserData_Fan.Add(item.Key, item.Object);
            }
        }
        public async Task GetUserData_Near()
        {
            var list = (await client
              .Child("User")
              .OrderBy("Dist")
              .LimitToFirst(5)
              .OnceAsync<UserData>());

            foreach (var item in list)
            {
                mDataMng.UserData_Near.Add(item.Key, item.Object);
            }
        }
        public async Task GetUserData_New()
        {
            var list = (await client
              .Child("User")
              .OrderBy("Date")
              .LimitToFirst(5)
              .OnceAsync<UserData>());

            foreach (var item in list)
            {
                mDataMng.UserData_New.Add(item.Key, item.Object);
            }
        }
    }
}
