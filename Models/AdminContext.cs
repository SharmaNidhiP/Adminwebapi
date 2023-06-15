using System;
using Microsoft.EntityFrameworkCore;
using Adminwebapi.Models;

namespace Adminwebapi.Models
{
    public class AdminContext:DbContext
    {
        public AdminContext(DbContextOptions options):base(options)
        {  
        }
        public  DbSet<Admin> Admin{get;set;}
        
        
    }
}
