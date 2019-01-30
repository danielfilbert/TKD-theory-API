using System.Collections.Generic;
using TKD_theory_api.Data;
using TKD_theory_api.Models;

namespace TKD_theory_api
{
    interface IMapper
    {
        IEnumerable<KorTheoryItem> MapKorItems(IEnumerable<DbKorTheoryItems> dbKorTheoryItems);
        IEnumerable<DanTheoryItem> MapDanItems(IEnumerable<DbDanTheoryItems> dbDanItems);
        IEnumerable<EngTheoryItem> MapEngItems(IEnumerable<DbEngTheoryItems> dbEngTheoryItems);
        IEnumerable<TheoryLanguages> MapLanguages(IEnumerable<DbTheoryLanguages> dbTheoryLanguages);
    }
}
