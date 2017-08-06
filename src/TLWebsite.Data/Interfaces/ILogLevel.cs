// Copyright (c) Lakithu. All rights reserved.

using System;
using TLWebsite.Data.Utils;

namespace TLWebsite.Data.Interfaces
{
    public interface ILogLevel
    {
        string SetLogType(string message);

        string Debug(string message);

        string Info(string message);

        string Warn(string message);

        string Warn(string message, Exception ex);

        string Error(string message);

        string Error(string message, Exception ex);

        string Fatal(string message);

        string Fatal(string message, Exception ex);

        string Log(string message,LogLevelsEnum logLevel);

        string Log(string message, Exception ex, LogLevelsEnum logLevel);
    }
}
