using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.Mobile.Service;

namespace moneyfactoryService.DataObjects
{
    public class CommentItem : EntityData
    {
        public string Text { get; set; }
        public string CustomerId { get; set; }
        public string EventID { get; set; }
        public DateTime Date { get; set; }

    }
}