using System;
using System.Collections.Generic;
using System.Text;

namespace Talkking2.Model
{
    class DataMng
    {
        private static DataMng _Instance;

        public static DataMng getInstance()
        {
            if (_Instance == null)
                _Instance = new DataMng();

            return _Instance;
        }

        public MyData mMyData = new MyData();

        public Dictionary<string, UserData> CacheData_Card = new Dictionary<string, UserData>();
        public Dictionary<string, UserData> CacheData_Fan = new Dictionary<string, UserData>();


        public Dictionary<string, UserData> UserData_Fan = new Dictionary<string, UserData>();
        public Dictionary<string, UserData> UserData_Heart = new Dictionary<string, UserData>();
        public Dictionary<string, UserData> UserData_Near = new Dictionary<string, UserData>();
        public Dictionary<string, UserData> UserData_New = new Dictionary<string, UserData>();



    }
}
