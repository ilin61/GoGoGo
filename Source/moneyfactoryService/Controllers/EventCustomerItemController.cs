using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using moneyfactoryService.DataObjects;
using moneyfactoryService.Models;

namespace moneyfactoryService.Controllers
{
    public class EventCustomerItemController : TableController<EventCustomerItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            moneyfactoryContext context = new moneyfactoryContext();
            DomainManager = new EntityDomainManager<EventCustomerItem>(context, Request, Services);
        }

        // GET tables/EventCustomerItem
        public IQueryable<EventCustomerItem> GetAllEventCustomerItem()
        {
            return Query(); 
        }

        // GET tables/EventCustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<EventCustomerItem> GetEventCustomerItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/EventCustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<EventCustomerItem> PatchEventCustomerItem(string id, Delta<EventCustomerItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/EventCustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostEventCustomerItem(EventCustomerItem item)
        {
            EventCustomerItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/EventCustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteEventCustomerItem(string id)
        {
             return DeleteAsync(id);
        }

    }
}