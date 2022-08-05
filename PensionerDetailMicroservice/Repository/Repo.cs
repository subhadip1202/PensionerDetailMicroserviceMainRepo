using Microsoft.EntityFrameworkCore;
using PensionerDetailMicroservice.Data;
using PensionerDetailMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace PensionerDetailMicroservice.Repository
{
    public class Repo :IRepo
    {
        private readonly MTwoPensionDbContext _pensionDbContext;

        public Repo(MTwoPensionDbContext pensionDbContext)
        {
            _pensionDbContext = pensionDbContext;

        }

        public dynamic getAllDetails(int id) {
           return _pensionDbContext.pensionerDetailModels.Where(p => p.aadharno == id).FirstOrDefault();
        }

 

    }
}
