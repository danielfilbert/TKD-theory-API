using FakeItEasy;
using NUnit.Framework;
using System.Collections.Generic;
using TKDTheoryApi.Controllers;
using TKDTheoryApi.Models;

namespace TKDTheoryApi.test
{
    [TestFixture]
    class TheoryItemControllerTest
    {
        [Test]
        public void GetDanTheoryItems200Test()
        {
            var context = A.Fake<ITKDTheoryAppContext>();
            var seedData = new SeedData();
            var danTheoryItems = new List<DanTheoryItem>
            {
                seedData.GetDanTheoryItem(1),
                seedData.GetDanTheoryItem(2),
                seedData.GetDanTheoryItem(3)
            };
            A.CallTo(() => context.GetDanTheoryItems()).Returns(danTheoryItems);
            var controller = new TheoryItemController(context);

            var result = controller.GetDanTheoryItems();
            Assert.AreEqual(danTheoryItems, result.Value);
        }
    }
}
