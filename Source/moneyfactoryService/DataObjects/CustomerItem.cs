using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moneyfactoryService.DataObjects
{
    public class CustomerItem: EntityData 
    {
        public string Name { get; set;  }
    }
}