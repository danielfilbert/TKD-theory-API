using System.Collections.Generic;

namespace TKD_theory_api.Models
{
    interface ITKDTheoryAppContext
    {
        IEnumerable<KorTheoryItem> GetKorTheoryItems();

        IEnumerable<DanTheoryItem> GetDanTheoryItems();
        IEnumerable<EngTheoryItem> GetEngTheoryItems();
        IEnumerable<TheoryLanguages> GetTheoryLanguages();

        //Get current categories //the user should be able to create new categories and subcategories
        //KorTheoryItem GetKorTheoryItem(int id); //this should maybe be limited to categories or subcategories as well or have a option to do so
        //DanTheoryItem GetDanTheoryItem(int id); //this should include the id desired for the kor theory item
        //KorTheoryItem GetEngTheoryItem(int id);

    }
}
