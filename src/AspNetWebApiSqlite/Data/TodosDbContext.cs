using AspNetWebApiSqlite.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AspNetWebApiSqlite.Data;

public class TodosDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Todo> Todos { get; set; }
}