using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nlc_2310900014.Models;

public partial class Nguyenlinhchi2310900014Context : DbContext
{
    public Nguyenlinhchi2310900014Context()
    {
    }

    public Nguyenlinhchi2310900014Context(DbContextOptions<Nguyenlinhchi2310900014Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NlcEmployee> NlcEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= LINHCHI\\SQLEXPRESS02;Database= Nguyenlinhchi_2310900014;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NlcEmployee>(entity =>
        {
            entity.HasKey(e => e.NlcEmpId);

            entity.ToTable("NlcEmployee");

            entity.Property(e => e.NlcEmpId)
                .ValueGeneratedNever()
                .HasColumnName("NlcEmpID");
            entity.Property(e => e.NlcEmpLevel).HasMaxLength(50);
            entity.Property(e => e.NlcEmpName).HasMaxLength(100);
            entity.Property(e => e.NlcEmpStartDate).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
