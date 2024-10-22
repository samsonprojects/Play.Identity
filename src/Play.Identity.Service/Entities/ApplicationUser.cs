using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace Play.Identity.Service.Entities
{
    [CollectionName("Users")]  //mongo dbcollection name
    public class ApplicationUser : MongoIdentityUser<Guid>
    {
        public decimal Gil { get; set; }  //represents how much money user has
        public HashSet<Guid> MessageIds { get; set; } = new();



    }
}