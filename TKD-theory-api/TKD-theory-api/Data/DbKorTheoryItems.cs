namespace TKDTheoryApi.Data
{
    public partial class DbKorTheoryItems
    {
        public int Id { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
        public string SubToSubCategory { get; set; }
        public string NameLatin { get; set; }
        public string NameHangul { get; set; }
        public string NamePhonetic { get; set; }
        public string NameAudio { get; set; }
    }
}
