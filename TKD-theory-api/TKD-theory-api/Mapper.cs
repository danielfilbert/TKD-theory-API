using System.Collections.Generic;
using TKDTheoryApi.Data;
using TKDTheoryApi.Models;

namespace TKDTheoryApi
{
    public class Mapper : IMapper
    {
        public KorTheoryItem MapKorItem(DbKorTheoryItems dbKorTheoryItem)
        {
            var korTheoryItem = new KorTheoryItem
            {
                Id = dbKorTheoryItem.Id,
                MainCategory = dbKorTheoryItem.MainCategory,
                SubCategory = dbKorTheoryItem.SubCategory,
                SubToSubCategory = dbKorTheoryItem.SubToSubCategory,
                NameLatin = dbKorTheoryItem.NameLatin,
                NameHangul = dbKorTheoryItem.NameHangul,
                NamePhonetic = dbKorTheoryItem.NamePhonetic,
                NameAudio = dbKorTheoryItem.NameAudio
            };
            return korTheoryItem;
        }

        public IEnumerable<KorTheoryItem> MapKorItems(IEnumerable<DbKorTheoryItems> dbKorTheoryItems)
        {
            var korItems = new List<KorTheoryItem>();
            foreach(var item in dbKorTheoryItems)
            {
                korItems.Add(MapKorItem(item));
            }
            return korItems;
        }

        public DanTheoryItem MapDanItem(DbDanTheoryItems dbDanTheoryItem)
        {
            var danTheoryItem = new DanTheoryItem
            {
                Id = dbDanTheoryItem.Id,
                KoreanTheoryItemId = dbDanTheoryItem.KoreanTheoryItemId,
                MainCategory = dbDanTheoryItem.MainCategory,
                SubCategory = dbDanTheoryItem.SubCategory,
                SubToSubCategory = dbDanTheoryItem.SubToSubCategory,
                NameLatin = dbDanTheoryItem.NameLatin,
                NamePhonetic = dbDanTheoryItem.NamePhonetic,
                NameAudio = dbDanTheoryItem.NameAudio
            };
            return danTheoryItem;
        }

        public IEnumerable<DanTheoryItem> MapDanItems(IEnumerable<DbDanTheoryItems> dbDanTheoryItems)
        {
            var danItems = new List<DanTheoryItem>();
            foreach(var item in dbDanTheoryItems)
            {
                danItems.Add(MapDanItem(item));
            }
            return danItems;
        }

        public EngTheoryItem MapEngItem(DbEngTheoryItems dbEngTheoryItem)
        {
            var engTheoryItem = new EngTheoryItem
            {
                Id = dbEngTheoryItem.Id,
                KoreanTheoryItemId = dbEngTheoryItem.KoreanTheoryItemId,
                MainCategory = dbEngTheoryItem.MainCategory,
                SubCategory = dbEngTheoryItem.SubCategory,
                SubToSubCategory = dbEngTheoryItem.SubToSubCategory,
                NameLatin = dbEngTheoryItem.NameLatin,
                NamePhonetic = dbEngTheoryItem.NamePhonetic,
                NameAudio = dbEngTheoryItem.NameAudio
            };
            return engTheoryItem;
        }

        public IEnumerable<EngTheoryItem> MapEngItems(IEnumerable<DbEngTheoryItems> dbEngTheoryItems)
        {
            var engItems = new List<EngTheoryItem>();
            foreach (var item in dbEngTheoryItems)
            {
                engItems.Add(MapEngItem(item));
            }
            return engItems;
        }

        public IEnumerable<TheoryLanguages> MapLanguages(IEnumerable<DbTheoryLanguages> dbTheoryLanguages)
        {
            var languages = new List<TheoryLanguages>();
            foreach(var language in dbTheoryLanguages)
            {
                var theoryLanguage = new TheoryLanguages
                {
                    CountryCode = language.CountryCode,
                    Name = language.Name
                };
                languages.Add(theoryLanguage);
            }
            return languages;
        }
    }
}
