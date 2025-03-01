using System;
using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
  public required DbSet<Activity> Activities { get; set; }
}