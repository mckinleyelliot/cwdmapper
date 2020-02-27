using Microsoft.EntityFrameworkCore;
namespace iLcwdMapper.Models
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users { get;set;}
        public DbSet<Processor> Processors { get;set;}
    }
}