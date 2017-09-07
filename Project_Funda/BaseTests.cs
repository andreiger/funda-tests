using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Framework;

namespace Tests
{
    public class BaseTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Instantiate();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Shutdown();
        }
    }
}
