using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GaberkornEL.Sprint0.Task2.V0.Lib;
namespace Tyuiu.GaberkornEL.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        public void CheckGetMessageValid()
        {
            var name = "Егор";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Егор", res);
        }
    }
}
