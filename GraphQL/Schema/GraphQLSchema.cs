using GraphQL.Types;
using EmployeeAPI.GraphQL.GraphQLRoots;

namespace EmployeeAPI.GraphQL
{
    public class GraphQLSchema:Schema
    {
        public GraphQLSchema(IServiceProvider serviceProvider): base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
