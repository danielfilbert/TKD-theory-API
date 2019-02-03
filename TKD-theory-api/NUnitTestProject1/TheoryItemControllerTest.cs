using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
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
        public void GetKorTheoryItems200Test()
        {
            var context = A.Fake<ITKDTheoryAppContext>();
            var seedData = new SeedData();
            var korTheoryItems = new List<KorTheoryItem>
            {
                seedData.GetKorTheoryItem(1),
                seedData.GetKorTheoryItem(2),
                seedData.GetKorTheoryItem(3)
            };
            A.CallTo(() => context.GetKorTheoryItems()).Returns(korTheoryItems);
            var controller = new TheoryItemController(context);

            var result = controller.GetKorTheoryItems();
            Assert.AreEqual(korTheoryItems, result.Value);
        }

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

        [Test]
        public void GetEngTheoryItems200Test()
        {
            var context = A.Fake<ITKDTheoryAppContext>();
            var seedData = new SeedData();
            var engTheoryItems = new List<EngTheoryItem>
            {
                seedData.GetEngTheoryItem(1),
                seedData.GetEngTheoryItem(2),
                seedData.GetEngTheoryItem(3)
            };
            A.CallTo(() => context.GetEngTheoryItems()).Returns(engTheoryItems);
            var controller = new TheoryItemController(context);

            var result = controller.GetEngTheoryItems();
            Assert.AreEqual(engTheoryItems, result.Value);
        }

        [Test]
        public void GetKorTheoryItem200Test()
        {
            int id = 123;
            var context = A.Fake<ITKDTheoryAppContext>();
            var seedData = new SeedData();
            var korTheoryItem = seedData.GetKorTheoryItem(id);
            A.CallTo(() => context.GetKorTheoryItem(id)).Returns(korTheoryItem);
            var controller = new TheoryItemController(context);

            var result = controller.GetKorTheoryItem(id);
            Assert.AreEqual(korTheoryItem, result.Value);
        }

        [Test]
        public void GetKorTheoryItem404Test()
        {
            int id = 123;
            var context = A.Fake<ITKDTheoryAppContext>();
            A.CallTo(() => context.GetKorTheoryItem(id)).Returns(null);
            var controller = new TheoryItemController(context);

            var result = controller.GetKorTheoryItem(id);
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }
        
        [Test]
        public void GetDanTheoryItem200Test()
        {
            int id = 123;
            var context = A.Fake<ITKDTheoryAppContext>();
            var seedData = new SeedData();
            var danTheoryItem = seedData.GetDanTheoryItem(id);
            A.CallTo(() => context.GetDanTheoryItem(id)).Returns(danTheoryItem);
            var controller = new TheoryItemController(context);

            var result = controller.GetDanTheoryItem(id);
            Assert.AreEqual(danTheoryItem, result.Value);
        }

        [Test]
        public void GetDanTheoryItem404Test()
        {
            int id = 123;
            var context = A.Fake<ITKDTheoryAppContext>();
            A.CallTo(() => context.GetDanTheoryItem(id)).Returns(null);
            var controller = new TheoryItemController(context);

            var result = controller.GetDanTheoryItem(id);
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }

        [Test]
        public void GetEngTheoryItem200Test()
        {
            int id = 123;
            var context = A.Fake<ITKDTheoryAppContext>();
            var seedData = new SeedData();
            var engTheoryItem = seedData.GetEngTheoryItem(id);
            A.CallTo(() => context.GetEngTheoryItem(id)).Returns(engTheoryItem);
            var controller = new TheoryItemController(context);

            var result = controller.GetEngTheoryItem(id);
            Assert.AreEqual(engTheoryItem, result.Value);
        }

        [Test]
        public void GetEngTheoryItem404Test()
        {
            int id = 123;
            var context = A.Fake<ITKDTheoryAppContext>();
            A.CallTo(() => context.GetEngTheoryItem(id)).Returns(null);
            var controller = new TheoryItemController(context);

            var result = controller.GetEngTheoryItem(id);
            Assert.IsInstanceOf<NotFoundResult>(result.Result);
        }
    }
}
