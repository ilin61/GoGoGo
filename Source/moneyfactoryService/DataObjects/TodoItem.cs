using Microsoft.WindowsAzure.Mobile.Service;

namespace moneyfactoryService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}