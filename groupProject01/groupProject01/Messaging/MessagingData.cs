﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace groupProject01
{
	public class MessagingData
	{
        public List<MessageObject> messages { get; set; } //creates an instance of messages
        public List<GroupObject> groups { get; set; } //creates an instance of groups

		public MessagingData ()
		{
            refreshAll();
		}

        /// <summary>
        /// Refreshes all lists by creating a new instance and adding the necessary things.
        /// </summary>
        public void refreshAll()
        {
            groups = new List<GroupObject>();

            groups.Add(new GroupObject());
        }

        /// <summary>
        /// Fills the Message with the necessary data.
        /// </summary>
        /// <param name="apartmentID"></param>
        async public Task getItemsInMessage(GlobalData gd)
        {
            messages = new List<MessageObject>();

            messages = await (ServerHandeler.getMessages(gd));

            
        }
    }
    public class GroupObject
    {
        public int GroupID = 0;
        public string GroupName = "General";
    }

    public class MessageObject {
        private int iD = 0;
        private string _text = "";
        private int _senderID = 0;
        private int _recieverID = 0;
        private int _apartmentID = 0;
        private string _name = "";

        public string MSGText
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }

        public int SenderID
        {
            get
            {
                return _senderID;
            }

            set
            {
                _senderID = value;
            }
        }

        public int RecieverID
        {
            get
            {
                return _recieverID;
            }

            set
            {
                _recieverID = value;
            }
        }

        public int apartmentID
        {
            get
            {
                return _apartmentID;
            }

            set
            {
                _apartmentID = value;
            }
        }

        public string SenderName
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public MessageObject()
        {
            
        }

        public void sendToServer(GlobalData gdFile)
        {

        }

    }

}
