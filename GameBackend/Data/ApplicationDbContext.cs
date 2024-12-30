using System;
using GameBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace GameBackend.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Category> Categories { get; set; }
}
