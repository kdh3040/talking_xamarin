using System;
using System.Collections.Generic;
using System.Text;

namespace Talkking2.Model
{
    class UserData
    {
        private static UserData _Instance;

        public static UserData getInstance()
        {
            if (_Instance == null)
                _Instance = new UserData();

            return _Instance;
        }

        public bool bMyData
        {
            get;
            set;
        }

        public string UId
        {
            get;
            set;
        }
        public string Idx
        {
            get;
            set;
        }
        public string Token
        {
            get;
            set;
        }
        public string Img
        {
            get;
            set;
        }
        public string NickName
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string Age
        {
            get;
            set;
        }
        public double Lat
        {
            get;
            set;
        }
        public double Lon
        {
            get;
            set;
        }
        public double Dist
        {
            get;
            set;
        }
        public int Honey
        {
            get;
            set;
        }
        public int Heart
        {
            get;
            set;
        }
        public long RecvGold
        {
            get;
            set;
        }
        public long Date
        {
            get;
            set;
        }
        public string Memo
        {
            get;
            set;
        }
        public int ImgCount
        {
            get;
            set;
        }
        public string ImgCroup0
        {
            get;
            set;
        }
        public string ImgCroup1
        {
            get;
            set;
        }
        public string ImgCroup2
        {
            get;
            set;
        }
        public string ImgCroup3
        {
            get;
            set;
        }

        public int Item_1
        {
            get;
            set;
        }
        public int Item_2
        {
            get;
            set;
        }
        public int Item_3
        {
            get;
            set;
        }
        public int Item_4
        {
            get;
            set;
        }
        public int Item_5
        {
            get;
            set;
        }
        public int Item_6
        {
            get;
            set;
        }
        public int Item_7
        {
            get;
            set;
        }


        public int Point
        {
            get;
            set;
        }
        public int ConnectDate
        {
            get;
            set;
        }
        public long LastBoardWriteTime
        {
            get;
            set;
        }
        public long LastAdsTime
        {
            get;
            set;
        }

        public int NickChangeCnt
        {
            get;
            set;
        }

        public long FanCount
        {
            get;
            set;
        }

        public List<UserData> UserData_Heart = new List<UserData>();
        public List<UserData> UserData_Fan = new List<UserData>();
        public List<UserData> UserData_Near = new List<UserData>();
        public List<UserData> UserData_New = new List<UserData>();

        SortedList<string, CardData> CardList = new SortedList<string, CardData>();
        SortedList<string, UserData> CardData = new SortedList<string, UserData>();

        SortedList<string, FanData> FanList = new SortedList<string, FanData>();
        SortedList<string, UserData> FanData = new SortedList<string, UserData>();



    }
}
