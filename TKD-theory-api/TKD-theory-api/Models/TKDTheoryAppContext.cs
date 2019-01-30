using System.Collections.Generic;

namespace TKD_theory_api.Models
{
    public class TKDTheoryAppContext : ITKDTheoryAppContext
    {
        public IEnumerable<DanTheoryItem> GetDanTheoryItems()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<EngTheoryItem> GetEngTheoryItems()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<KorTheoryItem> GetKorTheoryItems()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TheoryLanguages> GetTheoryLanguages()
        {
            throw new System.NotImplementedException();
        }
    }
}
