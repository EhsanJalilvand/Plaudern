﻿using ChatClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationShare.Dtos
{
    public class ContactModel
    {
        private string _name;
        private string _ip;
        private readonly ObservableCollection<MessageModel> _messages = new ObservableCollection<MessageModel>();
        public event PropertyChangedEventHandler? PropertyChanged;
        public string Name
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
        public string Ip
        {
            get
            {
                return _ip;
            }
            set
            {
                _ip = value;
            }
        }
        public ObservableCollection<MessageModel> Messages
        {
            get { return _messages; }
        }
    }
}

