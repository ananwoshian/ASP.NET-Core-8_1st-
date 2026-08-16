using Microsoft.EntityFrameworkCore;
using 代辦事項.Models;

namespace 代辦事項.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //上面這串我沒有很理解，總之 DbContextOptions是一個語法套用在我定義的類別"AppDbContext"上，然後我這個類別裡面有一個options
            //但我要啟用這個options的話，我就要用 base(options)才可以啟用 DbContextOptions這個語法的功能
        }
        public DbSet<Items> Items { get; set; }
    }
}
