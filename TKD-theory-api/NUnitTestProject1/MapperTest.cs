using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TKDTheoryApi.Data;

namespace TKDTheoryApi.test
{
    [TestFixture]

    public class MapperTest
    {
        [Test]
        public void GetKorTheoryItemTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbKorTheoryItem = seedData.GetDbKorTheoryItem(1);

            var result = mapper.MapKorItem(dbKorTheoryItem);

            Assert.AreEqual(dbKorTheoryItem.Id, result.Id);
            Assert.AreEqual(dbKorTheoryItem.MainCategory, result.MainCategory);
            Assert.AreEqual(dbKorTheoryItem.SubCategory, result.SubCategory);
            Assert.AreEqual(dbKorTheoryItem.SubToSubCategory, result.SubToSubCategory);
            Assert.AreEqual(dbKorTheoryItem.NameLatin, result.NameLatin);
            Assert.AreEqual(dbKorTheoryItem.NameHangul, result.NameHangul);
            Assert.AreEqual(dbKorTheoryItem.NamePhonetic, result.NamePhonetic);
            Assert.AreEqual(dbKorTheoryItem.NameAudio, result.NameAudio);
        }

        [Test]
        public void GetKorTheoryItemsTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbKorTheoryItems = new List<DbKorTheoryItems>();

            for (int i = 0; i < 10; i++)
            {
                dbKorTheoryItems.Add(seedData.GetDbKorTheoryItem(i));
            }

            var result = mapper.MapKorItems(dbKorTheoryItems).ToList();

            Assert.AreEqual(dbKorTheoryItems[0].Id, result[0].Id);
            Assert.AreEqual(dbKorTheoryItems[1].Id, result[1].Id);
            Assert.AreNotEqual(dbKorTheoryItems[0].Id, result[1].Id);

            Assert.AreEqual(dbKorTheoryItems[0].MainCategory, result[0].MainCategory);
            Assert.AreEqual(dbKorTheoryItems[0].SubCategory, result[0].SubCategory);
            Assert.AreEqual(dbKorTheoryItems[0].SubToSubCategory, result[0].SubToSubCategory);
            Assert.AreEqual(dbKorTheoryItems[0].NameLatin, result[0].NameLatin);
            Assert.AreEqual(dbKorTheoryItems[0].NameHangul, result[0].NameHangul);
            Assert.AreEqual(dbKorTheoryItems[0].NamePhonetic, result[0].NamePhonetic);
            Assert.AreEqual(dbKorTheoryItems[0].NameAudio, result[0].NameAudio);
        }

        [Test]
        public void GetDanTheoryItemTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbDanTheoryItem = seedData.GetDbDanTheoryItem(1);

            var result = mapper.MapDanItem(dbDanTheoryItem);

            Assert.AreEqual(dbDanTheoryItem.Id, result.Id);
            Assert.AreEqual(dbDanTheoryItem.KoreanTheoryItemId, result.KoreanTheoryItemId);
            Assert.AreEqual(dbDanTheoryItem.MainCategory, result.MainCategory);
            Assert.AreEqual(dbDanTheoryItem.SubCategory, result.SubCategory);
            Assert.AreEqual(dbDanTheoryItem.SubToSubCategory, result.SubToSubCategory);
            Assert.AreEqual(dbDanTheoryItem.NameLatin, result.NameLatin);
            Assert.AreEqual(dbDanTheoryItem.NamePhonetic, result.NamePhonetic);
            Assert.AreEqual(dbDanTheoryItem.NameAudio, result.NameAudio);
        }

        [Test]
        public void GetDanTheoryItemsTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbDanTheoryItems = new List<DbDanTheoryItems>();

            for (int i = 0; i < 10; i++)
            {
                dbDanTheoryItems.Add(seedData.GetDbDanTheoryItem(i));
            }

            var result = mapper.MapDanItems(dbDanTheoryItems).ToList();

            Assert.AreEqual(dbDanTheoryItems[0].Id, result[0].Id);
            Assert.AreEqual(dbDanTheoryItems[1].Id, result[1].Id);
            Assert.AreNotEqual(dbDanTheoryItems[0].Id, result[1].Id);

            Assert.AreEqual(dbDanTheoryItems[0].KoreanTheoryItemId, result[0].KoreanTheoryItemId);
            Assert.AreEqual(dbDanTheoryItems[0].MainCategory, result[0].MainCategory);
            Assert.AreEqual(dbDanTheoryItems[0].SubCategory, result[0].SubCategory);
            Assert.AreEqual(dbDanTheoryItems[0].SubToSubCategory, result[0].SubToSubCategory);
            Assert.AreEqual(dbDanTheoryItems[0].NameLatin, result[0].NameLatin);
            Assert.AreEqual(dbDanTheoryItems[0].NamePhonetic, result[0].NamePhonetic);
            Assert.AreEqual(dbDanTheoryItems[0].NameAudio, result[0].NameAudio);
        }
        [Test]
        public void GetEngTheoryItemTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbEngTheoryItem = seedData.GetDbEngTheoryItem(1);

            var result = mapper.MapEngItem(dbEngTheoryItem);

            Assert.AreEqual(dbEngTheoryItem.Id, result.Id);
            Assert.AreEqual(dbEngTheoryItem.KoreanTheoryItemId, result.KoreanTheoryItemId);
            Assert.AreEqual(dbEngTheoryItem.MainCategory, result.MainCategory);
            Assert.AreEqual(dbEngTheoryItem.SubCategory, result.SubCategory);
            Assert.AreEqual(dbEngTheoryItem.SubToSubCategory, result.SubToSubCategory);
            Assert.AreEqual(dbEngTheoryItem.NameLatin, result.NameLatin);
            Assert.AreEqual(dbEngTheoryItem.NamePhonetic, result.NamePhonetic);
            Assert.AreEqual(dbEngTheoryItem.NameAudio, result.NameAudio);
        }

        [Test]
        public void GetEngTheoryItemsTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbEngTheoryItems = new List<DbEngTheoryItems>();

            for (int i = 0; i < 10; i++)
            {
                dbEngTheoryItems.Add(seedData.GetDbEngTheoryItem(i));
            }

            var result = mapper.MapEngItems(dbEngTheoryItems).ToList();

            Assert.AreEqual(dbEngTheoryItems[0].Id, result[0].Id);
            Assert.AreEqual(dbEngTheoryItems[1].Id, result[1].Id);
            Assert.AreNotEqual(dbEngTheoryItems[0].Id, result[1].Id);

            Assert.AreEqual(dbEngTheoryItems[0].KoreanTheoryItemId, result[0].KoreanTheoryItemId);
            Assert.AreEqual(dbEngTheoryItems[0].MainCategory, result[0].MainCategory);
            Assert.AreEqual(dbEngTheoryItems[0].SubCategory, result[0].SubCategory);
            Assert.AreEqual(dbEngTheoryItems[0].SubToSubCategory, result[0].SubToSubCategory);
            Assert.AreEqual(dbEngTheoryItems[0].NameLatin, result[0].NameLatin);
            Assert.AreEqual(dbEngTheoryItems[0].NamePhonetic, result[0].NamePhonetic);
            Assert.AreEqual(dbEngTheoryItems[0].NameAudio, result[0].NameAudio);
        }

        [Test]
        public void GetTheoryLanguageTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbTheoryLanguage = seedData.GetDbTheoryLanguages();

            var result = mapper.MapLanguage(dbTheoryLanguage);

            Assert.AreEqual(dbTheoryLanguage.CountryCode, result.CountryCode);
            Assert.AreEqual(dbTheoryLanguage.Name, result.Name);
        }

        [Test]
        public void GetTheoryLanguagesTest()
        {
            var mapper = new Mapper();
            var seedData = new SeedData();
            var dbTheoryLanguages = new List<DbTheoryLanguages>();

            dbTheoryLanguages.Add(seedData.GetDbTheoryLanguages());
            dbTheoryLanguages.Add(seedData.GetDbTheoryLanguages("ENG", "English"));

            var result = mapper.MapLanguages(dbTheoryLanguages).ToList();

            Assert.AreEqual(dbTheoryLanguages[0].CountryCode, result[0].CountryCode);
            Assert.AreEqual(dbTheoryLanguages[1].CountryCode, result[1].CountryCode);
            Assert.AreEqual(dbTheoryLanguages[0].Name, result[0].Name);
            Assert.AreEqual(dbTheoryLanguages[1].Name, result[1].Name);
            Assert.AreNotEqual(dbTheoryLanguages[0].CountryCode, result[1].CountryCode);
            Assert.AreNotEqual(dbTheoryLanguages[0].Name, result[1].Name);
        }
    }
}