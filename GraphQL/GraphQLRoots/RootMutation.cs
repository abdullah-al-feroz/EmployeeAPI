using EmployeeAPI.GraphQL.Mutation;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.GraphQLRoots
{
    public class RootMutation: ObjectGraphType
    {
        public RootMutation()
        {
            Name = "RootMutation";
            Field<EmployeeMutation>("employees", resolve: context => new { });
            Field<DepartmentMutation>("departments", resolve: context => new { });
        }

    }
}
