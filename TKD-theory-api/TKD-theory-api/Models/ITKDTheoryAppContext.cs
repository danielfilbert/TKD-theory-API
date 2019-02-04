using System.Collections.Generic;

namespace TKDTheoryApi.Models
{
    public interface ITKDTheoryAppContext
    {
        KorTheoryItem GetKorTheoryItem(int id);
        DanTheoryItem GetDanTheoryItem(int id);
        EngTheoryItem GetEngTheoryItem(int id);

        IEnumerable<KorTheoryItem> GetKorTheoryItems();

        IEnumerable<DanTheoryItem> GetDanTheoryItems();
        IEnumerable<EngTheoryItem> GetEngTheoryItems();

        TheoryLanguages GetTheoryLanguage(string countryCode);
        IEnumerable<TheoryLanguages> GetTheoryLanguages();

        DanTheoryItem PostDanTheoryItem(DanTheoryItem danTheoryItem);
        //Get current categories //the user should be able to create new categories and subcategories

    }
}
