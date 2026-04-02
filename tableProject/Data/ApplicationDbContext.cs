using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using tableProject.Models;

namespace tableProject.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; } = default!;
    public DbSet<Table> Tables { get; set; } = default!;
    public DbSet<Column> Columns { get; set; } = default!;
    public DbSet<Row> Rows { get; set; } = default!;
    public DbSet<Cell> Cells { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Restrict cascading deletes on Column and Row to avoid multiple cascade paths to Cell
        builder.Entity<Cell>()
            .HasOne(c => c.Column)
            .WithMany(col => col.Cells)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Cell>()
            .HasOne(c => c.Row)
            .WithMany(r => r.Cells)
            .OnDelete(DeleteBehavior.Restrict);
    }
}