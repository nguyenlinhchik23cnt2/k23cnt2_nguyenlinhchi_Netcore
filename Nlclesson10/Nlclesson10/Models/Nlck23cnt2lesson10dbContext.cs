using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nlclesson10.Models;

public partial class Nlck23cnt2lesson10dbContext : DbContext
{
    public Nlck23cnt2lesson10dbContext()
    {
    }

    public Nlck23cnt2lesson10dbContext(DbContextOptions<Nlck23cnt2lesson10dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NlcCate> NlcCates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= LINHCHI\\SQLEXPRESS02;Database= Nlck23cnt2lesson10db;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NlcCate>(entity =>
        {
            entity.HasKey(e => e.CatId);

            entity.ToTable("NLcCate");

            entity.Property(e => e.CatId)
                .ValueGeneratedNever()
                .HasColumnName("CatID");
            entity.Property(e => e.CateName).HasMaxLength(150);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
