using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace moneyfactoryService.DataObjects
{
    public class EventItem : EntityData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SmallDescription { get; set; }
        public DateTime Date { get; set;  }
        public int MaxCustomers { get; set; }
        public int MinCustomers { get; set; }
        public int CurCustomers { get;set; }
        public int Status { get; set; }
    }
}