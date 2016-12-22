using CandyCorner.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CandyCorner.Controllers
{
    public class PostsController : ApiController
    {
        private ApplicationDbContext _ctx;
        public PostsController()
        {
            this._ctx = new ApplicationDbContext();
        }

        // GET api/<controller>
        public IEnumerable<Post> Get()
        {
            return this._ctx.Posts.OrderByDescending(x => x.DatePosted).ToList();
        }
    }
}
