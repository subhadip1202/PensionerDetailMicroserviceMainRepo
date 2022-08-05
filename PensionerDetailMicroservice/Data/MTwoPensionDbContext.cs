using Microsoft.EntityFrameworkCore;
using PensionerDetailMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailMicroservice.Data
{
    public class MTwoPensionDbContext : DbContext
    {
        public MTwoPensionDbContext(DbContextOptions options) :base(options)
        {
        }

        public DbSet<PensionerDetailModel> pensionerDetailModels { get; set; }


    }
}


