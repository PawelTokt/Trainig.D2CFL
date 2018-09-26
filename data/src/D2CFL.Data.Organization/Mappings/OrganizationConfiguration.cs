﻿using System;
using Aurochses.Data.EntityFrameworkCore;
using Aurochses.Data.Extensions.MsSql;
using D2CFL.Data.Organization.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D2CFL.Data.Organization.Mappings
{
    public class OrganizationConfiguration : EntityTypeConfiguration<OrganizationEntity, Guid>
    {
        public OrganizationConfiguration(string schemaName)
            : base(schemaName)
        {

        }

        public override void Map(EntityTypeBuilder<OrganizationEntity> entityTypeBuilder)
        {
            //Table
            entityTypeBuilder.ToTable("Organization", SchemaName);

            // Primary Key
            entityTypeBuilder.HasKey(x => x.Id);

            // Properties
            entityTypeBuilder.Property(x => x.Name).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength(ColumnLengths.UniqueName)).IsRequired();
            entityTypeBuilder.Property(x => x.Abbreviation).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength(ColumnLengths.UniqueName)).IsRequired();
            entityTypeBuilder.Property(x => x.Region).HasColumnType(ColumnTypes.GetNVarCharWithSpecifiedLength(ColumnLengths.UniqueName)).IsRequired();
        }
    }
}