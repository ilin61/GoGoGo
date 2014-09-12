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
    public class CommentItemController : TableController<CommentItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            moneyfactoryContext context = new moneyfactoryContext();
            DomainManager = new EntityDomainManager<CommentItem>(context, Request, Services);
        }

        // GET tables/CommentItem
        public IQueryable<CommentItem> GetAllCommentItem()
        {
            return Query(); 
        }

        // GET tables/CommentItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<CommentItem> GetCommentItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/CommentItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<CommentItem> PatchCommentItem(string id, Delta<CommentItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/CommentItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public async Task<IHttpActionResult> PostCommentItem(CommentItem item)
        {
            CommentItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/CommentItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteCommentItem(string id)
        {
             return DeleteAsync(id);
        }

    }
}