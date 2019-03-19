using CandyEShopData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CandyEShopData
{
    public class EShopContext:DbContext
    {
        public EShopContext(DbContextOptions<EShopContext> options) : base(options) { }
        DbSet<Item> ItemsTable { get; set; }
    }
}
