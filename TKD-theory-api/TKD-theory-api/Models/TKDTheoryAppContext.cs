using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TKDTheoryApi.Data;

namespace TKDTheoryApi.Models
{
    public class TKDTheoryAppContext : ITKDTheoryAppContext
    {
        private readonly IMapper _mapper;
        private readonly IDbContext _dbContext;

        public TKDTheoryAppContext(IDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public KorTheoryItem GetKorTheoryItem(int id)
        {
            var dbKorTheoryItem = _dbContext.KorTheoryItems.SingleOrDefault(dbKorTheoryItemCond => dbKorTheoryItemCond.Id == id);

            if (dbKorTheoryItem == null)
            {
                return null;
            }
            var korTheoryItem = _mapper.MapKorItem(dbKorTheoryItem);

            return korTheoryItem;
        }

        public DanTheoryItem GetDanTheoryItem(int id)
        {
            var dbDanTheoryItem = _dbContext.DanTheoryItems.SingleOrDefault(dbDanTheoryItemCond => dbDanTheoryItemCond.Id == id);

            if (dbDanTheoryItem == null)
            {
                return null;
            }
            var danTheoryItem = _mapper.MapDanItem(dbDanTheoryItem);

            return danTheoryItem;
        }

        public EngTheoryItem GetEngTheoryItem(int id)
        {
            var dbEngTheoryItem = _dbContext.EngTheoryItems.SingleOrDefault(dbEngTheoryItemCond => dbEngTheoryItemCond.Id == id);

            if (dbEngTheoryItem == null)
            {
                return null;
            }
            var engTheoryItem = _mapper.MapEngItem(dbEngTheoryItem);

            return engTheoryItem;
        }

        public IEnumerable<KorTheoryItem> GetKorTheoryItems()
        {
            var dbKorTheoryItems = _dbContext.KorTheoryItems;

            if (dbKorTheoryItems == null || !dbKorTheoryItems.Any())
            {
                return null;
            }
            var korTheoryItems = _mapper.MapKorItems(dbKorTheoryItems);

            return korTheoryItems;
        }

        public IEnumerable<DanTheoryItem> GetDanTheoryItems()
        {
            var dbDanTheoryItems = _dbContext.DanTheoryItems;

            if (dbDanTheoryItems == null || !dbDanTheoryItems.Any())
            {
                return null;
            }
            var danTheoryItems = _mapper.MapDanItems(dbDanTheoryItems);

            return danTheoryItems;
        }

        public IEnumerable<EngTheoryItem> GetEngTheoryItems()
        {
            var dbEngTheoryItems = _dbContext.EngTheoryItems;

            if (dbEngTheoryItems == null || !dbEngTheoryItems.Any())
            {
                return null;
            }
            var engTheoryItems = _mapper.MapEngItems(dbEngTheoryItems);

            return engTheoryItems;
        }

        public TheoryLanguages GetTheoryLanguage(string countryCode)
        {
            var dbTheoryLanguage = _dbContext.TheoryLanguages.SingleOrDefault(dbTheoryLanguageCond => dbTheoryLanguageCond.CountryCode == countryCode);

            if(dbTheoryLanguage == null)
            {
                return null;
            }
            var theoryLanguage = _mapper.MapLanguage(dbTheoryLanguage);
            return theoryLanguage;
        }

        public IEnumerable<TheoryLanguages> GetTheoryLanguages()
        {
            var dbTheoryLanguages = _dbContext.TheoryLanguages;

            if (dbTheoryLanguages == null || !dbTheoryLanguages.Any())
            {
                return null;
            }
            var theoryLanguages = _mapper.MapLanguages(dbTheoryLanguages);

            return theoryLanguages;
        }

        public DanTheoryItem PostDanTheoryItem(DanTheoryItem danTheoryItem)
        {
            var theoryItem = new DbDanTheoryItems
            {
                Id = danTheoryItem.Id,
                KoreanTheoryItemId = danTheoryItem.KoreanTheoryItemId,
                MainCategory = danTheoryItem.MainCategory,
                SubCategory = danTheoryItem.SubCategory,
                SubToSubCategory = danTheoryItem.SubToSubCategory,
                NameLatin = danTheoryItem.NameLatin,
                NamePhonetic = danTheoryItem.NamePhonetic,
                NameAudio = danTheoryItem.NameAudio
            };
            _dbContext.DanTheoryItems.Add(theoryItem);
            return danTheoryItem;
        }
    }
}
