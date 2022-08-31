using Microsoft.EntityFrameworkCore;
using RazorPizzeria1.Models;
using System;

namespace RazorPizzeria1.DataBase;

public class ApplicationDbContext : DbContext
{
    public DbSet<PizzaOrder> PIZZA { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
    {

    }

   
}