// Copyright (c) Lakithu. All rights reserved.
using TLWebsite.Data.Interfaces;

namespace TLWebsite.Data
{
    public class Logger : ILogger
    {
        private ILogLevel logLevels;

        public Logger(string loggerName)
        {
            this.logLevels = new LogLevel(loggerName);
        }

        public Logger(ILogLevel plogLevels)
        {
            this.logLevels = plogLevels;
        }

        public ILogLevel Data()
        {
            this.logLevels.SetLogType("Data");
            return this.logLevels;
        }

        public ILogLevel LogIn()
        {
            this.logLevels.SetLogType("LogIn");
            return this.logLevels;
        }

        public ILogLevel Posts()
        {
            this.logLevels.SetLogType("Posts");
            return this.logLevels;
        }
    }
}
