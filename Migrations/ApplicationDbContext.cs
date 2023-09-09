using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using teacher_crud.Models;

namespace teacher_crud.Migrations;

    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context): base(context){

        }

        public DbSet<Teacher> Teachers {get;set;}
    }
