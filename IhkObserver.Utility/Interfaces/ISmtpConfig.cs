﻿namespace IhkObserver.Utility.Interfaces
{
    public interface ISmtpConfig
    {
        public string Host { get; }
        public int Port { get; }
        public string SenderPassword { get; }
    }
}