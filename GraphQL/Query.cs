using System.Linq;
using commander_graphql.Data;
using commander_graphql.Models;
using HotChocolate;

namespace commander_graphql.GraphQL
{
    public class Query
    {
        public IQueryable<Platform> GetPlatform([Service] AppDbContext context)
        {
            return context.Platforms;
        }
    }
}