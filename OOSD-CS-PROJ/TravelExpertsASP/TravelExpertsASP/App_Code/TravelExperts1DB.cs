using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TravelExpertsASP.App_Code
{
    public class TravelExperts1DB
    {
        // connecting to the DB
         SqlConnection conn  = new SqlConnection("TravelExpertsConnectionString connectionString=Server= tcp:oosdgroup2.database.windows.net,1433; Initial Catalog = TravelExperts1; Persist Security Info=False;User ID = mchadds; Password=oOSD1234.;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
    }
}