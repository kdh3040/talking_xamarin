using System;
using System.Collections.Generic;
using System.Text;

namespace Talkking2.Model
{
    class UserData
    {
        public string Age
        {
            get;
            set;
        }
        public int ConnectDate
        {
            get;
            set;
        }
        public long Date
        {
            get;
            set;
        }
        public double Dist
        {
            get;
            set;
        }
        public long FanCount
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public int Honey
        {
            get;
            set;
        }
        public string Idx
        {
            get;
            set;
        }
        public string Img
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
        public int NickChangeCnt
        {
            get;
            set;
        }
        public string NickName
        {
            get;
            set;
        }
        public int Point
        {
            get;
            set;
        }
        public long RecvGold
        {
            get;
            set;
        }
        public string Token
        {
            get;
            set;
        }
      

        //Dictionary<string, CardData> CardList = new Dictionary<string, CardData>();
        //Dictionary<string, FanData> FanList = new Dictionary<string, FanData>();
        //Dictionary<string, LastChatData> LastChatList = new Dictionary<string, LastChatData>();

    }

    class CardData
    {
        public string Idx
        {
            get;
            set;
        }
    }


    class FanData
    {
        public string Idx
        {
            get;
            set;
        }
        public int RecvGold
        {
            get;
            set;
        }
        public int Check
        {
            get;
            set;
        }
    }

    class LastChatData
    {
        public string Age
        {
            get;
            set;
        }
        public string TargetNick
        {
            get;
            set;
        }
        public string TargetImg
        {
            get;
            set;
        }
        public string TargetMsg
        {
            get;
            set;
        }
        public string SendName
        {
            get;
            set;
        }
        public long SendDate
        {
            get;
            set;
        }
        public int SendHoney
        {
            get;
            set;
        }
    }
}
