using TKDTheoryApi.Data;
using TKDTheoryApi.Models;

namespace TKDTheoryApi.test
{
    class SeedData
    {
        public DbKorTheoryItems GetDbKorTheoryItem(int id = 1)
        {
            return new DbKorTheoryItems
            {
                Id = id,
                MainCategory = $"TestMainCategory-{id}",
                SubCategory = $"TestSubCategory-{id}",
                SubToSubCategory = $"TestSubToSubCategory-{id}",
                NameLatin = $"TestNameLatin-{id}",
                NameHangul = $"TestNameHangul-{id}",
                NamePhonetic = $"TestNamePhonetic-{id}",
                NameAudio = $"TestNameAudio-{id}"
            };
        }

        public DbDanTheoryItems GetDbDanTheoryItem(int id = 1)
        {
            return new DbDanTheoryItems
            {
                Id = id,
                KoreanTheoryItemId = id + 1,
                MainCategory = $"TestDanMainCategory-{id}",
                SubCategory = $"TestDanSubCategory-{id}",
                SubToSubCategory = $"TestDanSubToSubCategory-{id}",
                NameLatin = $"TestDanNameLatin-{id}",
                NamePhonetic = $"TestDanNamePhonetic-{id}",
                NameAudio = $"TestDanNameAudio-{id}"
            };
        }

        public DbEngTheoryItems GetDbEngTheoryItem(int id = 1)
        {
            return new DbEngTheoryItems
            {
                Id = id,
                KoreanTheoryItemId = id + 1,
                MainCategory = $"TestEngMainCategory-{id}",
                SubCategory = $"TestEngSubCategory-{id}",
                SubToSubCategory = $"TestEngSubToSubCategory-{id}",
                NameLatin = $"TestEngNameLatin-{id}",
                NamePhonetic = $"TestEngNamePhonetic-{id}",
                NameAudio = $"TestEngNameAudio-{id}"
            };
        }

        public KorTheoryItem GetKorTheoryItem(int id)
        {
            return new KorTheoryItem
            {
                Id = id,
                MainCategory = $"TestMainCategory-{id}",
                SubCategory = $"TestSubCategory-{id}",
                SubToSubCategory = $"TestSubToSubCategory-{id}",
                NameLatin = $"TestNameLatin-{id}",
                NameHangul = $"TestNameHangul-{id}",
                NamePhonetic = $"TestNamePhonetic-{id}",
                NameAudio = $"TestNameAudio-{id}"
            };
        }

        public DanTheoryItem GetDanTheoryItem(int id = 1)
        {
            return new DanTheoryItem
            {
                Id = id,
                KoreanTheoryItemId = id + 1,
                MainCategory = $"TestDanMainCategory-{id}",
                SubCategory = $"TestDanSubCategory-{id}",
                SubToSubCategory = $"TestDanSubToSubCategory-{id}",
                NameLatin = $"TestDanNameLatin-{id}",
                NamePhonetic = $"TestDanNamePhonetic-{id}",
                NameAudio = $"TestDanNameAudio-{id}"
            };
        }

        public EngTheoryItem GetEngTheoryItem(int id = 1)
        {
            return new EngTheoryItem
            {
                Id = id,
                KoreanTheoryItemId = id + 1,
                MainCategory = $"TestEngMainCategory-{id}",
                SubCategory = $"TestEngSubCategory-{id}",
                SubToSubCategory = $"TestEngSubToSubCategory-{id}",
                NameLatin = $"TestEngNameLatin-{id}",
                NamePhonetic = $"TestEngNamePhonetic-{id}",
                NameAudio = $"TestEngNameAudio-{id}"
            };
        }

        public DbTheoryLanguages GetDbTheoryLanguages(string countryCode = "DKK", string name = "Dansk")
        {
            return new DbTheoryLanguages
            {
                CountryCode = countryCode,
                Name = name
            };
        }

        public TheoryLanguages GetTheoryLanguages(string countryCode = "DKK", string name = "Dansk")
        {
            return new TheoryLanguages
            {
                CountryCode = countryCode,
                Name = name
            };
        }
    }
}
