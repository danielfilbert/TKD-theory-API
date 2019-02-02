using FakeItEasy;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TKDTheoryApi.Data;
using TKDTheoryApi.Models;

namespace TKDTheoryApi.test
{
    [TestFixture]
    public class TKDTheoryAppContextTest
    {
        [Test]
        public void GetKorTheoryItemTest()
        {
            var dbContext = GetFakeDbContext(3);
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);

            var result = context.GetKorTheoryItem(1);

            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].Id, result.Id);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].MainCategory, result.MainCategory);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].SubCategory, result.SubCategory);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].SubToSubCategory, result.SubToSubCategory);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].NameLatin, result.NameLatin);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].NameHangul, result.NameHangul);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].NamePhonetic, result.NamePhonetic);
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[1].NameAudio, result.NameAudio);
        }

        [Test]
        public void GetDanTheoryItemTest()
        {
            var dbContext = GetFakeDbContext(3);
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);

            var result = context.GetDanTheoryItem(1);

            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].Id, result.Id);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].KoreanTheoryItemId, result.KoreanTheoryItemId);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].MainCategory, result.MainCategory);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].SubCategory, result.SubCategory);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].SubToSubCategory, result.SubToSubCategory);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].NameLatin, result.NameLatin);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].NamePhonetic, result.NamePhonetic);
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[1].NameAudio, result.NameAudio);
        }

        [Test]
        public void GetEngTheoryItemTest()
        {
            var dbContext = GetFakeDbContext(3);
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);

            var result = context.GetEngTheoryItem(0);

            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].Id, result.Id);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].KoreanTheoryItemId, result.KoreanTheoryItemId);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].MainCategory, result.MainCategory);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].SubCategory, result.SubCategory);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].SubToSubCategory, result.SubToSubCategory);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].NameLatin, result.NameLatin);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].NamePhonetic, result.NamePhonetic);
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].NameAudio, result.NameAudio);
        }

        [Test]
        public void GetKorTheoryItemsTest()
        {
            var dbContext = GetFakeDbContext(2);
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);

            var result = context.GetKorTheoryItems();

            Assert.AreEqual(2, result.Count());
            Assert.AreEqual(dbContext.KorTheoryItems.ToList()[0].MainCategory, result.ToList()[0].MainCategory);
        }

        [Test]
        public void GetDanTheoryItemsTest()
        {
            var dbContext = GetFakeDbContext(3);
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);

            var result = context.GetDanTheoryItems();

            Assert.AreEqual(3, result.Count());
            Assert.AreEqual(dbContext.DanTheoryItems.ToList()[0].MainCategory, result.ToList()[0].MainCategory);
        }

        [Test]
        public void GetEngTheoryItemsTest()
        {
            var dbContext = GetFakeDbContext(5);
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);

            var result = context.GetEngTheoryItems();

            Assert.AreEqual(5, result.Count());
            Assert.AreEqual(dbContext.EngTheoryItems.ToList()[0].MainCategory, result.ToList()[0].MainCategory);
        }

        [Test]
        public void GetTheoryLanguageTest()
        {
            var dbContext = GetFakeDbContext();
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);
            var result = context.GetTheoryLanguage("DKK");

            Assert.AreEqual(dbContext.TheoryLanguages.SingleOrDefault(countryCode => countryCode.CountryCode == "DKK").CountryCode, result.CountryCode);
            Assert.AreEqual(dbContext.TheoryLanguages.SingleOrDefault(countryCode => countryCode.CountryCode == "DKK").Name, result.Name);
        }

        [Test]
        public void GetTheoryLanguagesTest()
        {
            var dbContext = GetFakeDbContext();
            var mapper = new Mapper();
            var context = new TKDTheoryAppContext(dbContext, mapper);
            var result = context.GetTheoryLanguages();

            Assert.AreEqual(3, result.Count());
        }

        private IDbContext GetFakeDbContext(int noOfTheoryItems = 1)
        {
            var dbContext = A.Fake<IDbContext>();
            var seedData = new SeedData();

            var korItemsTemp = new List<DbKorTheoryItems>();
            var danItemsTemp = new List<DbDanTheoryItems>();
            var engItemsTemp = new List<DbEngTheoryItems>();
            var languagesTemp = new List<DbTheoryLanguages>();

            for (int i = 0; i < noOfTheoryItems; i++)
            {
                korItemsTemp.Add(seedData.GetDbKorTheoryItem(i));
                danItemsTemp.Add(seedData.GetDbDanTheoryItem(i));
                engItemsTemp.Add(seedData.GetDbEngTheoryItem(i));
            }

            languagesTemp.Add(seedData.GetDbTheoryLanguages());
            languagesTemp.Add(seedData.GetDbTheoryLanguages("ENG", "English"));
            languagesTemp.Add(seedData.GetDbTheoryLanguages("KOR", "Korean"));

            var korItemsList = korItemsTemp.AsQueryable();
            var danItemsList = danItemsTemp.AsQueryable();
            var engItemsList = engItemsTemp.AsQueryable();
            var languageList = languagesTemp.AsQueryable();

            var fakeKorItems = A.Fake<DbSet<DbKorTheoryItems>>(builder => builder.Implements(typeof(IQueryable<DbKorTheoryItems>)));
            var fakeDanItems = A.Fake<DbSet<DbDanTheoryItems>>(builder => builder.Implements(typeof(IQueryable<DbDanTheoryItems>)));
            var fakeEngItems = A.Fake<DbSet<DbEngTheoryItems>>(builder => builder.Implements(typeof(IQueryable<DbEngTheoryItems>)));
            var fakeLanguages = A.Fake<DbSet<DbTheoryLanguages>>(builder => builder.Implements(typeof(IQueryable<DbTheoryLanguages>)));

            A.CallTo(() => ((IQueryable<DbKorTheoryItems>)fakeKorItems).Provider).Returns(korItemsList.Provider);
            A.CallTo(() => ((IQueryable<DbKorTheoryItems>)fakeKorItems).Expression).Returns(korItemsList.Expression);
            A.CallTo(() => ((IQueryable<DbKorTheoryItems>)fakeKorItems).ElementType).Returns(korItemsList.ElementType);
            A.CallTo(() => ((IQueryable<DbKorTheoryItems>)fakeKorItems).GetEnumerator()).ReturnsLazily(() => korItemsList.GetEnumerator());

            A.CallTo(() => ((IQueryable<DbDanTheoryItems>)fakeDanItems).Provider).Returns(danItemsList.Provider);
            A.CallTo(() => ((IQueryable<DbDanTheoryItems>)fakeDanItems).Expression).Returns(danItemsList.Expression);
            A.CallTo(() => ((IQueryable<DbDanTheoryItems>)fakeDanItems).ElementType).Returns(danItemsList.ElementType);
            A.CallTo(() => ((IQueryable<DbDanTheoryItems>)fakeDanItems).GetEnumerator()).ReturnsLazily(() => danItemsList.GetEnumerator());

            A.CallTo(() => ((IQueryable<DbEngTheoryItems>)fakeEngItems).Provider).Returns(engItemsList.Provider);
            A.CallTo(() => ((IQueryable<DbEngTheoryItems>)fakeEngItems).Expression).Returns(engItemsList.Expression);
            A.CallTo(() => ((IQueryable<DbEngTheoryItems>)fakeEngItems).ElementType).Returns(engItemsList.ElementType);
            A.CallTo(() => ((IQueryable<DbEngTheoryItems>)fakeEngItems).GetEnumerator()).ReturnsLazily(() => engItemsList.GetEnumerator());

            A.CallTo(() => ((IQueryable<DbTheoryLanguages>)fakeLanguages).Provider).Returns(languageList.Provider);
            A.CallTo(() => ((IQueryable<DbTheoryLanguages>)fakeLanguages).Expression).Returns(languageList.Expression);
            A.CallTo(() => ((IQueryable<DbTheoryLanguages>)fakeLanguages).ElementType).Returns(languageList.ElementType);
            A.CallTo(() => ((IQueryable<DbTheoryLanguages>)fakeLanguages).GetEnumerator()).ReturnsLazily(() => languageList.GetEnumerator());

            dbContext.KorTheoryItems = fakeKorItems;
            dbContext.DanTheoryItems = fakeDanItems;
            dbContext.EngTheoryItems = fakeEngItems;
            dbContext.TheoryLanguages = fakeLanguages;

            return dbContext;
        }
    }
}