// Copyright (c) Lakithu. All rights reserved.

using Moq;
using NUnit.Framework;
using TLWebsite.Data;
using TLWebsite.Data.Interfaces;

namespace TLWebsite.Tests.LoggingTests
{
    public class LoggerTests
    {
        [Test]
        public void DataSetsLogType()
        {
            Mock<ILogLevel> mockLogLevel = new Mock<ILogLevel>();
            var logger = this.GetLogger(mockLogLevel.Object);
            logger.Data();
            mockLogLevel.Verify(m => m.SetLogType("Data"), Times.Once);
        }

        [Test]
        public void LogInSetsLogType()
        {
            Mock<ILogLevel> mockLogLevel = new Mock<ILogLevel>();
            var logger = this.GetLogger(mockLogLevel.Object);
            logger.LogIn();
            mockLogLevel.Verify(m => m.SetLogType("LogIn"), Times.Once);
        }

        [Test]
        public void PostSetsLogType()
        {
            Mock<ILogLevel> mockLogLevel = new Mock<ILogLevel>();
            var logger = this.GetLogger(mockLogLevel.Object);
            logger.Posts();
            mockLogLevel.Verify(m => m.SetLogType("Posts"), Times.Once);
        }

        private Logger GetLogger(ILogLevel mockLogLevel)
        {
            return new Logger(mockLogLevel);
        }
    }
}
