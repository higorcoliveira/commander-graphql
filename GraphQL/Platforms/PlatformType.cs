using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using commander_graphql.Models;
using commander_graphql.Data;

namespace commander_graphql.GraphQL.Platforms
{
    public class PlatformType : ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            // also can be configured as annotation in Platform class
            descriptor.Description("Represents any software or service that has a command line interface.");
            descriptor
                .Field(p => p.LicenseKey).Ignore();
            descriptor
                .Field(p => p.Commands)
                .ResolveWith<Resolvers>(p => p.GetCommands(default!, default!))
                .UseDbContext<AppDbContext>()
                .Description("This is the list of available commands for this platform.");
        }

        private class Resolvers
        {
            public IQueryable<Command> GetCommands(Platform platform, [ScopedService] AppDbContext context)
            {
                return context.Commands.Where(c => c.PlatformId == platform.Id);
            }
        }
    }
}