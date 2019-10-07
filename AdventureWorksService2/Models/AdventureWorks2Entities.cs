using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksService2.Models
{
    public partial class AdventureWorks2Entities
    {
        public AdventureWorks2Entities(string password)
            : base("name=AdventureWorks2Entities")
        {
            this.Database.Connection.ConnectionString += $";Password={password}";
        }
    }
        

}