using Microsoft.EntityFrameworkCore;
using Pizzeria.Persistence.DbContexts;


internal class DbContextFactory
{
    public static PizzeriaDbContext GetPizzeriaDbContext()
    {
        var Options = new DbContextOptionsBuilder<PizzeriaDbContext>()
            .UseSqlite("DataSource=file::memory:?cache=shared").Options;
            //.UseSqlite("DataSource=file.db").Options;

        return new PizzeriaDbContext(Options);
    }


}
