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
    public class CustomerItemController : TableController<CustomerItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            moneyfactoryContext context = new moneyfactoryContext();
            DomainManager = new EntityDomainManager<CustomerItem>(context, Request, Services);
        }

        // GET tables/CustomerItem
        public IQueryable<CustomerItem> GetAllCustomerItem()
        {
            return Query(); 
        }

        // GET tables/CustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<CustomerItem> GetCustomerItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/CustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<CustomerItem> PatchCustomerItem(string id, Delta<CustomerItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/CustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostCustomerItem(CustomerItem item)
        {
            CustomerItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/CustomerItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCustomerItem(string id)
        {
             return DeleteAsync(id);
        }

    }
}