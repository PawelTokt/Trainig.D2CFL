﻿//using Aurochses.Data.EntityFrameworkCore;
using D2CFL.Data.FantasyLeague.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace D2CFL.Data.FantasyLeague
{
    public class FantasyLeagueDbContext : DbContextBase<FantasyLeagueDbContext>
    {
        public FantasyLeagueDbContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new OrganizationConfiguration(SchemaName));
            builder.ApplyConfiguration(new PlayerConfiguration(SchemaName));
            builder.ApplyConfiguration(new PositionConfiguration(SchemaName));
        }
    }
}