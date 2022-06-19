using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.ToDoObjects;

namespace ToDoApp
{
    public class ToDoDbContext :DbContext
    {
        public DbSet<ToDoRecord> ToDoRecords { get; set; }
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }
    }
}
