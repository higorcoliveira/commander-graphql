using System.Linq;
using commander_graphql.Data;
using commander_graphql.Models;
using HotChocolate;
using HotChocolate.Data;

namespace commander_graphql.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}