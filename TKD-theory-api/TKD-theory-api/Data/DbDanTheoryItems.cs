﻿namespace TKDTheoryApi.Data
{
    public partial class DbDanTheoryItems
    {
        public int Id { get; set; }
        public int KoreanTheoryItemId { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public string SubToSubCategory { get; set; }
        public string NameLatin { get; set; }
        public string NamePhonetic { get; set; }
        public string NameAudio { get; set; }
    }
}
