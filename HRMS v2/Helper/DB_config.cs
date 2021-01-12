using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS_v2.Models;
using Microsoft.EntityFrameworkCore;
using HRMS_v2.ViewModel;

namespace HRMS_v2.Helper
{
    public class DB_config
    {
        public static HRMSContext db_conection()
        {
            string DBCONNECTION = CommanConfig.DBConnectionString.ToString();
            var optionsBuilder = new DbContextOptionsBuilder<HRMSContext>();
            optionsBuilder.UseSqlServer(DBCONNECTION, o => o.CommandTimeout(900));
            return new HRMSContext(optionsBuilder.Options);
        }
    }
}