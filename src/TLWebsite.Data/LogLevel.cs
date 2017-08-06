// Copyright (c) Lakithu. All rights reserved.

using System;
using log4net;
using TLWebsite.Data.Interfaces;
using TLWebsite.Data.Utils;

namespace TLWebsite.Data
{
    public class LogLevel : ILogLevel
    {
        private readonly ILog log;
        private string logType;

        public LogLevel(string loggerName)
        {
            this.log = LogManager.GetLogger(loggerName);
            this.logType = string.Empty;
        }

        public string Debug(string message)
        {
            return this.Log(message, LogLevelsEnum.DEBUG);
        }

        public string Error(string message)
        {
            return this.Log(message, LogLevelsEnum.ERROR);
        }

        public string Error(string message, Exception ex)
        {
            return this.Log(message, ex, LogLevelsEnum.ERROR);
        }

        public string Fatal(string message)
        {
            return this.Log(message, LogLevelsEnum.FATAL);
        }

        public string Fatal(string message, Exception ex)
        {
            return this.Log(message, ex, LogLevelsEnum.FATAL);
        }

        public string Info(string message)
        {
            return this.Log(message, LogLevelsEnum.INFO);
        }

        public string Log(string message, LogLevelsEnum logLevel)
        {
            string logMessage = this.logType + ": " + message;
            switch (logLevel)
            {
                case LogLevelsEnum.DEBUG:
                    this.log.Debug(logMessage);
                    logMessage = "Debug: " + logMessage;
                    break;
                case LogLevelsEnum.INFO:
                    this.log.Debug(logMessage);
                    logMessage = "Info: " + logMessage;
                    break;
                case LogLevelsEnum.WARN:
                    this.log.Debug(logMessage);
                    logMessage = "Warn: " + logMessage;
                    break;
                case LogLevelsEnum.ERROR:
                    this.log.Debug(logMessage);
                    logMessage = "Error: " + logMessage;
                    break;
                case LogLevelsEnum.FATAL:
                    this.log.Debug(logMessage);
                    logMessage = "Fatal: " + logMessage;
                    break;
                default:
                    logMessage = string.Empty;
                    break;
            }

            return logMessage;
        }

        public string Log(string message, Exception ex, LogLevelsEnum logLevel)
        {
            string logMessage = this.logType + ": " + message;
            switch (logLevel)
            {
                case LogLevelsEnum.WARN:
                    this.log.Debug(logMessage, ex);
                    logMessage = "Warn: " + logMessage;
                    break;
                case LogLevelsEnum.ERROR:
                    this.log.Debug(logMessage, ex);
                    logMessage = "Error: " + logMessage;
                    break;
                case LogLevelsEnum.FATAL:
                    this.log.Debug(logMessage, ex);
                    logMessage = "Fatal: " + logMessage;
                    break;
                default:
                    logMessage = string.Empty;
                    break;
            }

            return logMessage;
        }

        public string SetLogType(string message)
        {
            this.logType = message;
            return this.logType;
        }

        public string Warn(string message)
        {
            return this.Log(message, LogLevelsEnum.WARN);
        }

        public string Warn(string message, Exception ex)
        {
            return this.Log(message, ex, LogLevelsEnum.WARN);
        }
    }
}
