using EmployeeAPI.GraphQL.Query;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.GraphQLRoots
{
    public class RootQuery: ObjectGraphType
    {
        public RootQuery()
        {
            Name = "RootQuery";
            Field<EmployeeQuery>("employees", resolve: context => new { });
            Field<DepartmentQuery>("departments", resolve: context => new { });
        }
    }
}
