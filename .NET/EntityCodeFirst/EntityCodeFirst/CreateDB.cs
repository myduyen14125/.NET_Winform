using System.Data.Entity;

namespace EntityCodeFirst
{
    public class CreateDB : CreateDatabaseIfNotExists<QLSV>
    {
        protected override void Seed(QLSV context)
        {
            context.LopSHes.AddRange(new LopSH[]
            {
                new LopSH {ID_Lop = 1, NameLop = "18T"},
                new LopSH {ID_Lop = 2, NameLop = "19T"}
            });
            context.SVs.AddRange(new SV[]
            {
                new SV {MSSV = "101", NameSV = "NVA", ID_Lop = 1, DTB = 9.8},
                new SV {MSSV = "102", NameSV = "NVB", ID_Lop = 2, DTB = 9.5},
                new SV {MSSV = "103", NameSV = "Nga", ID_Lop = 1, DTB = 9.7},
            });
        }
    }
}