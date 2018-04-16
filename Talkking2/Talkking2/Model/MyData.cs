using System;
using System.Collections.Generic;
using System.Text;

namespace Talkking2.Model
{
    class MyData : UserData
    {
        Dictionary<string, ChatData> CardList = new Dictionary<string, ChatData>();
    }

    class ChatData
    {
        public string from
        {
            get;
            set;
        }
        public string fromIdx
        {
            get;
            set;
        }
        public string to
        {
            get;
            set;
        }
        public string msg
        {
            get;
            set;
        }

        public long time
        {
            get;
            set;
        }
        public string img
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public int Check
        {
            get;
            set;
        }
        public int Heart
        {
            get;
            set;
        }
    }
}
