﻿
using DomainShare.Enums;
using DomainShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Share.Application.Services
{
    public interface IServerMessageProvider
    {
        Task ListenMessageAsync(Action<MessageContract> callback);
        Task<bool> RemoveClientAsync(ContactInfo sender);
        Task<bool> SendMessageAsync(ContactInfo sender, ContactInfo receiver, string message,MessageType messageType);
    }
}
