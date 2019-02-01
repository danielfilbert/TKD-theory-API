﻿using System.Collections.Generic;
using TKDTheoryApi.Data;
using TKDTheoryApi.Models;

namespace TKDTheoryApi
{
    interface IMapper
    {
        KorTheoryItem MapKorItem(DbKorTheoryItems dbKorTheoryItem);
        DanTheoryItem MapDanItem(DbDanTheoryItems dbDanTheoryItem);
        EngTheoryItem MapEngItem(DbEngTheoryItems dbEngTheoryItem);
        IEnumerable<KorTheoryItem> MapKorItems(IEnumerable<DbKorTheoryItems> dbKorTheoryItems);
        IEnumerable<DanTheoryItem> MapDanItems(IEnumerable<DbDanTheoryItems> dbDanItems);
        IEnumerable<EngTheoryItem> MapEngItems(IEnumerable<DbEngTheoryItems> dbEngTheoryItems);
        IEnumerable<TheoryLanguages> MapLanguages(IEnumerable<DbTheoryLanguages> dbTheoryLanguages);
    }
}
