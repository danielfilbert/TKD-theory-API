using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TKDTheoryApi.Data;

namespace TKDTheoryApi.test
{
    public class Tests
    {
        [TestFixture]

        public class MapperTest
        {
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
        }

    }
}