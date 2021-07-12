using Retaurant_WebAPI.Models;
using System.Linq;
using System.Web.Http;

namespace Retaurant_WebAPI.Controllers
{
    public class ItemController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/Item
        public IQueryable<Item> GetItems()
        {
            return db.Items;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}