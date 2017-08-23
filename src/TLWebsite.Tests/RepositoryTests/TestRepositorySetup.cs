using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLWebsite.Data;
using TLWebsite.Data.DTO;
using TLWebsite.Data.Interfaces;
using TLWebsite.Data.Repositories;
using Moq;
using NUnit.Framework;

namespace TLWebsite.Tests.RepositoryTests
{
    public class TestRepositorySetup
    {
        public TestRepositorySetup()
        {
            Mock<Entities> context = new Mock<Entities>();

        }
    }
}
