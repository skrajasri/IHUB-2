using Intra_Hub_v2.Models;
using Intra_Hub_v2.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intra_Hub_v2.Helper
{
    public class DB_config
    {
        public static IntraHubv2Context db_conection()
        {
            string DBCONNECTION = CommanConfig.DBConnectionString.ToString();
            var optionsBuilder = new DbContextOptionsBuilder<IntraHubv2Context>();
            optionsBuilder.UseSqlServer(DBCONNECTION, o => o.CommandTimeout(900));
            return new IntraHubv2Context(optionsBuilder.Options);
        }
    }
}
