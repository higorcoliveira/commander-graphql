using commander_graphql.Models;
using HotChocolate;
using HotChocolate.Types;

namespace commander_graphql.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
        public Platform OnPlatformAdded([EventMessage] Platform platform) => platform;
    }
}