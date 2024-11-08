﻿using Microsoft.EntityFrameworkCore;


internal static class DbContextFactory
{
    public static PizzeriaDbContext GetPizzeriaDbContext()
    {
        var Options = new DbContextOptionsBuilder<PizzeriaDbContext>()
            .UseSqlite($"DataSource=file:DbContext_{Guid.NewGuid()}?mode=memory&cache=shared").Options;

        var dbContext = new PizzeriaDbContext(Options);
        ApplySeedsToContext.ApplySeeds(dbContext);

        return dbContext;
    }

}
