﻿using Autofac;
using D2CFL.Data.League;
using D2CFL.Business.League;
using Microsoft.EntityFrameworkCore;
using D2CFL.Business.League.Contract;
using Microsoft.Extensions.Configuration;

namespace D2CFL.WebSite.Admin.Autofac
{
    public static class Startup
    {
        public static void ConfigureContainer(ContainerBuilder containerBuilder, IConfiguration configuration)
        {
            containerBuilder.RegisterModule(
                new LeagueModule(
                    new DbContextOptionsBuilder<LeagueDbContext>()
                        .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                        .Options,
                    "league"
                )
            );

            containerBuilder.RegisterType<PlayerService>().As<IPlayerService>().InstancePerLifetimeScope();
        }
    }
}