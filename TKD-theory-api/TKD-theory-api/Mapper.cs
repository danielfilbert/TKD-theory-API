using System.Collections.Generic;
using TKD_theory_api.Data;
using TKD_theory_api.Models;

namespace TKD_theory_api
{
    public class Mapper : IMapper
    {
        public IEnumerable<KorTheoryItem> MapKorItems(IEnumerable<DbKorTheoryItems> dbKorTheoryItems)
        {
            throw new System.NotImplementedException();
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
