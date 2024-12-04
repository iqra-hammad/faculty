using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace faculty.Models;

public partial class EnvironmentDbContext : DbContext
{
    public EnvironmentDbContext()
    {
    }

    public EnvironmentDbContext(DbContextOptions<EnvironmentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Contactform> Contactforms { get; set; }

    public virtual DbSet<Contactnumber> Contactnumbers { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Emailaddress> Emailaddresses { get; set; }

    public virtual DbSet<Facultysurveyform> Facultysurveyforms { get; set; }

    public virtual DbSet<Specification> Specifications { get; set; }

    public virtual DbSet<StudentSurveyForm> StudentSurveyForms { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("PK__class__213EE774EA8F0061");

            entity.ToTable("class");

            entity.Property(e => e.CId).HasColumnName("c_id");
            entity.Property(e => e.Class1)
                .HasMaxLength(20)
                .HasColumnName("class");
        });

        modelBuilder.Entity<Contactform>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__contactf__B9BE370F823F647C");

            entity.ToTable("contactform");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Message)
                .HasMaxLength(100)
                .HasColumnName("message");
            entity.Property(e => e.Usercontactnumber)
                .HasMaxLength(30)
                .HasColumnName("usercontactnumber");
            entity.Property(e => e.Useremail)
                .HasMaxLength(100)
                .HasColumnName("useremail");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<Contactnumber>(entity =>
        {
            entity.HasKey(e => e.NId).HasName("PK__contactn__7371E14E00D6CCE6");

            entity.ToTable("contactnumber");

            entity.Property(e => e.NId).HasColumnName("n_id");
            entity.Property(e => e.Number)
                .HasMaxLength(100)
                .HasColumnName("number");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DId).HasName("PK__Departme__D95F582B08BFE6FF");

            entity.ToTable("Department");

            entity.Property(e => e.DId).HasColumnName("d_id");
            entity.Property(e => e.Departments)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Emailaddress>(entity =>
        {
            entity.HasKey(e => e.EId).HasName("PK__emailadd__3E2ED64A2C384026");

            entity.ToTable("emailaddress");

            entity.Property(e => e.EId).HasColumnName("e_id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
        });

        modelBuilder.Entity<Facultysurveyform>(entity =>
        {
            entity.HasKey(e => e.FId).HasName("PK__facultys__2911CBEDA725BAEF");

            entity.ToTable("facultysurveyform");

            entity.Property(e => e.FId).HasColumnName("f_id");
            entity.Property(e => e.Dept).HasColumnName("dept");
            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("designation");
            entity.Property(e => e.FName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("f_name");
            entity.Property(e => e.FNumber).HasColumnName("f_number");

            entity.HasOne(d => d.DeptNavigation).WithMany(p => p.Facultysurveyforms)
                .HasForeignKey(d => d.Dept)
                .HasConstraintName("FK__facultysur__dept__68487DD7");
        });

        modelBuilder.Entity<Specification>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PK__specific__2F3684F44F903B02");

            entity.ToTable("specifications");

            entity.Property(e => e.SId).HasColumnName("s_id");
            entity.Property(e => e.SName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("s_name");
        });

        modelBuilder.Entity<StudentSurveyForm>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("PK__StudentS__2F3684F4CFAA77DF");

            entity.ToTable("StudentSurveyForm");

            entity.Property(e => e.SId).HasColumnName("s_id");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Dateofadmission).HasColumnName("dateofadmission");
            entity.Property(e => e.Rollnumber).HasColumnName("rollnumber");
            entity.Property(e => e.SName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("s_name");
            entity.Property(e => e.Section)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Specification).HasColumnName("specification");

            entity.HasOne(d => d.ClassNavigation).WithMany(p => p.StudentSurveyForms)
                .HasForeignKey(d => d.Class)
                .HasConstraintName("FK__StudentSu__class__534D60F1");

            entity.HasOne(d => d.SpecificationNavigation).WithMany(p => p.StudentSurveyForms)
                .HasForeignKey(d => d.Specification)
                .HasConstraintName("FK__StudentSu__speci__5441852A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
