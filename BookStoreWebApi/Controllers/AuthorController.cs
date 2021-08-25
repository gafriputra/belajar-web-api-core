using BookStoreWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
      
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoresDBContext())
            {
                //get all authors
                //return context.Authors.ToList();

                //add a author
                //Author author = new Author();
                //author.FirstName = "Gafri";
                //author.LastName = "Putra";
                //context.Authors.Add(author);

                //updated author
                //Author author = context.Authors.Where(a => a.FirstName == "Gafri").FirstOrDefault();
                //author.Phone = "123456";

                //deleted author
                Author author = context.Authors.Where(a => a.FirstName == "Gafri").FirstOrDefault();
                context.Authors.Remove(author);

                context.SaveChanges();

                //get author where query
                return context.Authors.Where(a => a.FirstName == "Gafri").ToList();
            }
        }
    }
}
