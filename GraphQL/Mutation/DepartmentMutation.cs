using EmployeeAPI.GenericRepo;
using EmployeeAPI.GraphQL.InputTypes;
using EmployeeAPI.GraphQL.Type;
using EmployeeAPI.Model;
using GraphQL;
using GraphQL.Types;

namespace EmployeeAPI.GraphQL.Mutation
{
    public class DepartmentMutation:ObjectGraphType
    {
        private readonly IGenericRepo<Department> _department;

        public DepartmentMutation(IGenericRepo<Department> department)
        {
            _department = department;

            FieldAsync<DepartmentType>("CreateDepartment", "create a department",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<DepartmentInputType>> { Name = "department" }),

            resolve: async context =>
            {
                var department = context.GetArgument<Department>("department");
                await _department.AddItem(department);
                return department;
            });
        }
    }
}
