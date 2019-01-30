using Microsoft.EntityFrameworkCore;

namespace TKD_theory_api.Data
{
    public interface IDbContext
    {
        DbSet<DbDanTheoryItems> DanTheoryItems { get; set; }
        DbSet<DbEngTheoryItems> EngTheoryItems { get; set; }
        DbSet<DbKorTheoryItems> KorTheoryItems { get; set; }
        DbSet<DbTheoryLanguages> TheoryLanguages { get; set; }
        DbSet<DbUsers> Users { get; set; }
    }
}
