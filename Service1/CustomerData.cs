using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.Data;
using System.ServiceModel;

namespace Service1
{
    [DataContract]
    public class CustomerData
    {
        public CustomerData()
        {
            this.CustomersTable = new DataTable("CustomersData");
        }

        [DataMember]
        public DataTable CustomersTable { get; set; }
    }
}