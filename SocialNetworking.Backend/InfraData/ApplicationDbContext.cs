﻿using Domain.Entity;
using InfraData.Mapping;
using Microsoft.EntityFrameworkCore;

namespace InfraData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Friendship> Friendships { get; set; }
        public virtual DbSet<FileReference> FileReferences { get; set; }


        // ~ Migrations ~
        // In Console:
        // cd ./InfraData/
        // dotnet ef migrations add Initial -c ApplicationDbContext -s ..\APIRest\ -v
        // dotnet ef database update -c ApplicationDbContext -s ..\APIRest\ -v
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    //.UseLazyLoadingProxies() // ← resolvi retirar para melhorar a perfomance
                    //.EnableSensitiveDataLogging() // ← resolvi retirar para preservar a segurança
                    .UseSqlite("Data Source=database.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new FriendshipMap());
            modelBuilder.ApplyConfiguration(new FileReferenceMap());
        }
    }
}
