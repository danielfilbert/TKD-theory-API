using System.Collections.Generic;
using TKDTheoryApi.Data;
using TKDTheoryApi.Models;

namespace TKDTheoryApi
{
    public interface IMapper
    {
        KorTheoryItem MapKorItem(DbKorTheoryItems dbKorTheoryItem);
        DanTheoryItem MapDanItem(DbDanTheoryItems dbDanTheoryItem);
        EngTheoryItem MapEngItem(DbEngTheoryItems dbEngTheoryItem);
        IEnumerable<KorTheoryItem> MapKorItems(IEnumerable<DbKorTheoryItems> dbKorTheoryItems);
        IEnumerable<DanTheoryItem> MapDanItems(IEnumerable<DbDanTheoryItems> dbDanItems);
        IEnumerable<EngTheoryItem> MapEngItems(IEnumerable<DbEngTheoryItems> dbEngTheoryItems);
        TheoryLanguages MapLanguage(DbTheoryLanguages dbTheoryLanguage);
        IEnumerable<TheoryLanguages> MapLanguages(IEnumerable<DbTheoryLanguages> dbTheoryLanguages);
    }
}
