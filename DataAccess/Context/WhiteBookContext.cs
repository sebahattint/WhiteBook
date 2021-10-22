using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Whitebook.Whitebook.Dto.Entities;

namespace WhiteBookDataAccess.Context
{
    public class WhiteBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = (localdb)\mssqllocaldb; initial catalog =DbMvcProje; integrated security = true");
        }

        public DbSet<Content> Contents { get; set; }
        public DbSet<MainMenu>MainMenus { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Submenu> Submenus{ get; set; }
    }
}
