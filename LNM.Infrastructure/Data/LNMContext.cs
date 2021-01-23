//  LNMContext.cs
//
// Description: 
//       <Describe here>
//  Author:
//       Ryan Xu(XuChunlei) <hitxcl@gmail.com>
//  Create at:
//       0:23:45 22/1/2021
//
//  Copyright (c) 2021 XuChunlei
using System;
using LNM.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LNM.Infrastructure.Data
{
    public class LNMContext : IdentityDbContext<IdentityUser>
    {

        public LNMContext(DbContextOptions<LNMContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Brand>().ToTable("Brand");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Spu>().ToTable("Spu");

        }
    }
}
