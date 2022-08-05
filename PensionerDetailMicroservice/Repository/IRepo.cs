using PensionerDetailMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensionerDetailMicroservice.Repository
{
   public interface IRepo
    {
        dynamic getAllDetails(int id);

       

    }
}
