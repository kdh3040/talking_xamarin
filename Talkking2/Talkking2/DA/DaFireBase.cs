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
        FirebaseClient client;

        public DaFireBase()
        {
            client = new FirebaseClient("https://talkking-25dd8.firebaseio.com");
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

        public async Task<List<UserData>> getMyData()
        {
            var list = (await client
                .Child("User")
                .Child("50")
                .OnceAsync<UserData>())
                .Select(item =>
                        new UserData
                        {
                            Age = item.Object.Age,
                            NickName = item.Object.NickName
                        }).ToList();


            return list;

        }
    }
}
