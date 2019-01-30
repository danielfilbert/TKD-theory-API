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

        public IEnumerable<DanTheoryItem> MapDanItems(IEnumerable<DbDanTheoryItems> dbDanTheoryItems)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EngTheoryItem> MapEngItems(IEnumerable<DbEngTheoryItems> dbEngTheoryItems)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TheoryLanguages> MapLanguages(IEnumerable<DbTheoryLanguages> dbTheoryLanguages)
        {
            throw new System.NotImplementedException();
        }
    }
}
