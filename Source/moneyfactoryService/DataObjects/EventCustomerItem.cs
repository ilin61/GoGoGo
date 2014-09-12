using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moneyfactoryService.DataObjects
{
    public class EventCustomerItem: EntityData
    {
        public string EventID { get; set; }
        public string CustomerId { get; set; }
    }
}