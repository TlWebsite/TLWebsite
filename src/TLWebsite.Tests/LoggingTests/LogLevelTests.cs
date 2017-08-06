// Copyright (c) Lakithu. All rights reserved.

using System;
using log4net;
using Moq;
using NUnit.Framework;
using TLWebsite.Data;
using TLWebsite.Data.Utils;

namespace TLWebsite.Tests.LoggingTests
{
    public class LogLevelTests
    {
        [Test]
        public void DebugSetsLogLevel()
        {
            Mock<ILog> mockLogger = new Mock<ILog>();
            var logLevel = this.GetLogLevel(mockLogger.Object);
            logLevel.Debug("test");
            mockLogger.Verify(m => m.Debug(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void InfoSetsLogLevel()
        {
            Mock<ILog> mockLogger = new Mock<ILog>();
            var logLevel = this.GetLogLevel(mockLogger.Object);
            logLevel.Info("test");
            mockLogger.Verify(m => m.Info(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void WarnSetsLogLevel()
        {
            Mock<ILog> mockLogger = new Mock<ILog>();
            var logLevel = this.GetLogLevel(mockLogger.Object);
            logLevel.Warn("test");
            mockLogger.Verify(m => m.Warn(It.IsAny<string>()), Times.Once);
            logLevel.Warn("test", new Exception());
            mockLogger.Verify(m => m.Warn(It.IsAny<string>(), It.IsAny<Exception>()), Times.Once);
        }

        [Test]
        public void ErrorSetsLogLevel()
        {
            Mock<ILog> mockLogger = new Mock<ILog>();
            var logLevel = this.GetLogLevel(mockLogger.Object);
            logLevel.Error("test");
            mockLogger.Verify(m => m.Error(It.IsAny<string>()), Times.Once);
            logLevel.Error("test", new Exception());
            mockLogger.Verify(m => m.Error(It.IsAny<string>(), It.IsAny<Exception>()), Times.Once);
        }

        [Test]
        public void FatalSetsLogLevel()
        {
            Mock<ILog> mockLogger = new Mock<ILog>();
            var logLevel = this.GetLogLevel(mockLogger.Object);
            logLevel.Fatal("test");
            mockLogger.Verify(m => m.Fatal(It.IsAny<string>()), Times.Once);
            logLevel.Fatal("test", new Exception());
            mockLogger.Verify(m => m.Fatal(It.IsAny<string>(), It.IsAny<Exception>()), Times.Once);
        }

        [Test]
        public void LogInvalidLogLevel()
        {
            Mock<ILog> mockLogger = new Mock<ILog>();
            var logLevel = this.GetLogLevel(mockLogger.Object);
            var logMessage = logLevel.Log("Test", (LogLevelsEnum)5);
            Assert.AreEqual(string.Empty, logMessage);
            logMessage = logLevel.Log("Test", new Exception(), (LogLevelsEnum)5);
            Assert.AreEqual(string.Empty, logMessage);
        }

        private LogLevel GetLogLevel(ILog log)
        {
            return new LogLevel(log);
        }
    }
}
