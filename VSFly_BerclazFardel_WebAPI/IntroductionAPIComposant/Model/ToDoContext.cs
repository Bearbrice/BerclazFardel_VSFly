using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroductionAPIComposant.Model
{
    public class ToDoContext : DbContext
    {
        // Constructor
        public ToDoContext(DbContextOptions<ToDoContext> options):base(options) //to call the parent constructor we use base
        {

        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

    }
}
